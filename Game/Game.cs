﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
  internal class Game
  {
    //readonly byte[] buffer = new byte[4096];

    internal Game(Action<string> debugHelper)
    {
      DebugHelper = debugHelper;
    }

    private Action<string> DebugHelper { get; }

    private Weapon selectedWeapon = Weapon.None;

    internal async Task StartServerAsync()
    {
      TcpListener listener = new TcpListener(new IPEndPoint(IPAddress.Any, 9999));
      try
      {
        listener.Start();

        DebugHelper($"Waiting for connection from client...");
        using TcpClient handler = await listener.AcceptTcpClientAsync();
        await using NetworkStream stream = handler.GetStream();
        DebugHelper($"Client connected...");
        Net net = new Net(stream);
        var message = $"Connected to server";
        await net.SendAsync(new MessageObject(message));
        DebugHelper($">>>\"{message}");
        MessageObject messageFromClient = await net.ReceiveAsync();
        DebugHelper($"<<<{messageFromClient.Message}");

        while (true)
        {
          selectedWeapon = Weapon.None;

          while (selectedWeapon == Weapon.None)
          {
            await Task.Delay(100);
          }
          DebugHelper($"we played {selectedWeapon}");

          MessageObject messageFromClient2 = await net.ReceiveAsync();
          Weapon opponentPlayed = messageFromClient2.SelectedWeapon;
          DebugHelper($"Opponent played {opponentPlayed}");

          bool hostWins = false;
          if (selectedWeapon == opponentPlayed)
          {
            DebugHelper($"tied, try again.");
            await net.SendAsync(new MessageObject
            {
              Message = $"tied, try again.",
              Result = Result.Tied,
              SelectedWeapon = selectedWeapon
            });
            continue;
          }
          else
          {
            hostWins = (opponentPlayed - selectedWeapon + 3) % 3 == 1;
            DebugHelper($"You {(hostWins ? "win" : "lose")}!");
            await net.SendAsync(new MessageObject
            {
              MessageType = MessageType.Result,
              Result = hostWins ? Result.HostWins : Result.ClientWins,
              SelectedWeapon = selectedWeapon
            });
            //break;// afbryd forbindelsen med break,
            continue;// eller fortsæt med continue
          }
        }
      }
      catch (Exception e)
      {
        DebugHelper(e.Message);
      }
      finally
      {
        listener.Stop();
      }
    }


    internal async Task StartClientAsync()
    {
      using TcpClient client = new();
      // Connects faster on 127.0.0.1, than localhost.
      var ipAddress = IPAddress.Parse("127.0.0.1");

      DebugHelper($"Trying to connect to {ipAddress}");
      Task connectTask = client.ConnectAsync(ipAddress, 9999);
      Task cancelTask = Task.Delay(2000);
      await await Task.WhenAny(connectTask, cancelTask);
      if (cancelTask.IsCompleted)
      {
        DebugHelper($"Failed to connect!");
        return;
      }
      DebugHelper($"Connected to server");

      var stream = client.GetStream();
      Net net = new Net(stream);
      var messageFromServer = await net.ReceiveAsync();
      DebugHelper($"From server: {messageFromServer.Message}");

      var message = $"Hi from client!";
      await net.SendAsync(new MessageObject(message));

      while (true)
      {
        selectedWeapon = Weapon.None;
        while (selectedWeapon == Weapon.None)
        {
          await Task.Delay(100);
        }
        DebugHelper($"we played {selectedWeapon}");
        await net.SendAsync(new MessageObject
        {
          MessageType = MessageType.PlayedTurn,
          SelectedWeapon = selectedWeapon
        });

        // Get result, we are so exited!!!
        var objFromServer = await net.ReceiveAsync();
        var opponentPlayed = objFromServer.SelectedWeapon;
        DebugHelper($"Opponent played {opponentPlayed}");
        if (objFromServer.Result == Result.Tied)
        {
          DebugHelper($"We tied, try again.");
          continue;
        }
        else
        {
          DebugHelper($"We {(objFromServer.Result == Result.HostWins ? "lose" : "win")}!");
          //break;// afbryd forbindelsen med break,
          continue;// eller fortsæt med continue
        }
      }
    }
    internal void PlayerSelected(Weapon weapon)
    {
      selectedWeapon = weapon;
    }
  }
}