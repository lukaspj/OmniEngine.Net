﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server.Game
    {
    /// <summary>
    /// This class serves as the default code for the game code.
    /// this file should not be modified, but instead inherited and assigned to _gameBase member variable inside game.cs.
    /// </summary>
    public class gameBase : pInvokes
        {
     

        public virtual void initGame()
            {
            // Game duration in secs, no limit if the duration is set to 0
            iGlobal["$Game::Duration"] = 20 * 60;

            // When a client score reaches this value, the game is ended.
            iGlobal["$Game::EndGameScore"] = 30;

            // Pause while looking over the end game screen (in secs)
            iGlobal["$Game::EndGamePause"] = 10;
            }

        public virtual void loadDatablockFiles(List<string> datablockFiles, bool recurse)
            {
            if (recurse)
                {
                game.recursiveLoadDatablockFiles(datablockFiles, 9999);
                return;
                }
            int count = datablockFiles.Count;
            for (int i = 0; i < count; i++)
                {
                string file = datablockFiles[i];
                if (!Util.isFile(file))
                    continue;
                Util.exec(file, false, false);
                }
            }

        public virtual void recursiveLoadDatablockFiles(List<string> datablockFiles, int previousErrors)
            {
            List<string> badDatablocks = new List<string>();
            int newerrors = 0;
            foreach (string file in datablockFiles)
                {
                if (!Util.isFile(file))
                    {
                    Util._echo("Did not find '" + file + "'.");
                    continue;
                    }
                iGlobal["$Con::objectCopyFailures"] = 0;
                Util.exec(file, false, false);
                if (iGlobal["$Con::objectCopyFailures"] <= 0)
                    continue;
                badDatablocks.Add(file);
                newerrors++;
                }
            if (newerrors != previousErrors)
                game.recursiveLoadDatablockFiles(badDatablocks, newerrors);
            }

        public virtual void onServerCreated()
            {
            // Server::GameType is sent to the master server.
            // This variable should uniquely identify your game and/or mod.
            sGlobal["$Server::GameType"] = sGlobal["$appName"];

            // Server::MissionType sent to the master server.  Clients can
            // filter servers based on mission type.
            sGlobal["$Server::MissionType"] = "Deathmatch";

            // GameStartTime is the sim time the game started. Used to calculated
            // game elapsed time.
            iGlobal["$Game::StartTime"] = 0;

            // Create the server physics world.
            Util.physicsInitWorld("server");

            // Load up any objects or datablocks saved to the editor managed scripts
            List<string> datablockFiles = new List<string>();


            datablockFiles.Add("art/particles/managedParticleData.cs");
            datablockFiles.Add("art/particles/managedParticleEmitterData.cs");
            datablockFiles.Add("art/decals/managedDecalData.cs");
            datablockFiles.Add("art/datablocks/managedDatablocks.cs");
            datablockFiles.Add("art/forest/managedItemData.cs");
            datablockFiles.Add("art/datablocks/datablockExec.cs");
            game.loadDatablockFiles(datablockFiles, true);

            //Todo This is where ScriptExec usually is
            ScriptExec();


            // Keep track of when the game started
            dGlobal["$Game::StartTime"] = dGlobal["$Sim::Time"];
            }

        public virtual void ScriptExec()
            {
            iGlobal["$Camera::movementSpeed"] = 40;

            // Respawntime is the amount of time it takes for a static "auto-respawn"
            // object, such as an ammo box or weapon, to re-appear after it's been
            // picked up.  Any item marked as "static" is automaticlly respawned.
            iGlobal["$Item::RespawnTime"] = 30 * 1000;
            // Poptime represents how long dynamic items (those that are thrown or
            // dropped) will last in the world before being deleted.
            iGlobal["$Item::PopTime"] = 30 * 1000;

            iGlobal["$WeaponSlot"] = 0;

            // Timeouts for corpse deletion.
            iGlobal["$CorpseTimeoutValue"] = 45 * 1000;
            // Respawntime is the amount of time it takes for a static "auto-respawn"
            // turret to re-appear after it's been picked up.  Any turret marked as "static"
            // is automaticlly respawned.
            iGlobal["$TurretShape::RespawnTime"] = 30 * 1000;

            // DestroyedFadeDelay is the how long a destroyed turret sticks around before it
            // fades out and is deleted.
            iGlobal["$TurretShape::DestroyedFadeDelay"] = 5 * 1000;
            }

        public virtual void onServerDestroyed()
            {
            // This function is called as part of a server shutdown.
            Util.physicsDestroyWorld("server");
            // Clean up the GameCore package here as it persists over the
            // life of the server.

            if (Util.isPackage("GameCore"))
                Util.deactivatePackage("GameCore");
            }

        public virtual void endGame()
            {
            if (!bGlobal["$Game::Running"])
                {
                console.error("endGame: No game running.");
                return;
                }
            // Stop any game timers
            Util.cancel(iGlobal["$Game::Schedule"]);

            

            foreach (GameConnection client in ClientGroup)
                {
                console.commandToClient(client, "GameEnd", new[] { sGlobal["$Game::EndGamePause"] });
                }

            bGlobal["$Game::Running"] = false;
            }

        public virtual void onMissionEnded()
            {
            Util.physicsStopSimulation("server");
            game.endGame();
            Util.cancel(iGlobal["$Game::Schedule"]);
            bGlobal["$Game::Running"] = false;
            bGlobal["$Game::Cycling"] = false;
            }

        public virtual void onMissionLoaded()
            {
            //startGame();
            Server.game.initGameVars();

            ScriptObject game = "Game";
            sGlobal["$Game::Duration"] = game["duration"];
            sGlobal["$Game::EndGameScore"] = game["endgameScore"];
            sGlobal["$Game::EndGamePause"] = game["endgamePause"];

            Util.physicsStartSimulation("server");
            Server.game.startGame();
            }

        public virtual void startGame()
            {
            if (bGlobal["$Game::Running"])
                {
                Util._error("startGame: End the game first!");
                return;
                }
            // Inform the client we're starting up
            foreach (GameConnection client in ClientGroup)
                {
                console.commandToClient(client, "GameStart");
                client["score"] = "0";
                client["kills"] = "0";
                client["deaths"] = "0";
                }

            if (bGlobal["$Game::Duration"])
                iGlobal["$Game::Schedule"] =
                    ((ScriptObject)"Game").schedule((iGlobal["$Game::Duration"] * 1000).AsString(),
                        "onGameDurationEnd");

            bGlobal["$Game::Running"] = true;
            }

        public virtual void initGameVars()
            {
            //-----------------------------------------------------------------------------
            // What kind of "player" is spawned is either controlled directly by the
            // SpawnSphere or it defaults back to the values set here. This also controls
            // which SimGroups to attempt to select the spawn sphere's from by walking down
            // the list of SpawnGroups till it finds a valid spawn object.
            //-----------------------------------------------------------------------------
            sGlobal["$Game::DefaultPlayerClass"] = "Player";
            sGlobal["$Game::DefaultPlayerDataBlock"] = "DefaultPlayerData";
            sGlobal["$Game::DefaultPlayerSpawnGroups"] = "PlayerSpawnPoints PlayerDropPoints";

            //-----------------------------------------------------------------------------
            // What kind of "camera" is spawned is either controlled directly by the
            // SpawnSphere or it defaults back to the values set here. This also controls
            // which SimGroups to attempt to select the spawn sphere's from by walking down
            // the list of SpawnGroups till it finds a valid spawn object.
            //-----------------------------------------------------------------------------
            sGlobal["$Game::DefaultCameraClass"] = "Camera";
            sGlobal["$Game::DefaultCameraDataBlock"] = "Observer";
            sGlobal["$Game::DefaultCameraSpawnGroups"] = "CameraSpawnPoints PlayerSpawnPoints PlayerDropPoints";

            // Set the gameplay parameters
            ScriptObject game = "Game";

            game["duration"] = sGlobal["$Game::Duration"];
            game["endgameScore"] = sGlobal["$Game::EndGameScore"];
            game["endgamePause"] = sGlobal["$Game::EndGamePause"];
            game["allowCycling"] = false.AsString(); // Is mission cycling allowed?
            }

        public virtual ScriptObject createGame()
            {
            if ("theLevelInfo".isObject())
                {
                sGlobal["$Server::MissionType"] = ((LevelInfo)"theLevelInfo")["gameType"];
                }
            else
                {
                sGlobal["$Server::MissionType"] = string.Empty;
                }

            if (sGlobal["$Server::MissionType"] == string.Empty)
                sGlobal["$Server::MissionType"] = "Deathmatch";

            return new ObjectCreator("ScriptObject", "Game").Create();
            }

        public virtual void onMissionReset()
            {
            }
        }
    }