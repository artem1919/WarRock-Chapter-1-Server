﻿namespace Game.Enums {
    public enum GameSubs : ushort {
        Start = 1,
        StartReply = 4,
        RoundEndConfirm = 7,
        BackToLobby = 9,
        Ready = 50,
        MapUpdate = 51,
        ModeUpdate = 52,
        ChangeRounds = 53,
        ChangeKills = 55,
        SideUpdate = 56,
        Userlimit = 58,
        Pinglimit = 59,
        Votekick = 61,
        Autostart = 62,
        ConfirmSpawn = 100,
        Heal = 101,
        Repair = 102,
        PlayerDamage = 103,
        ObjectDamage = 104,
        AmmoRecharge = 105,
        Spawn = 150,
        PlayerDeath = 152,
        ObjectDestroy = 153,
        ConfirmDeath = 154,
        WeaponSwapping = 155,
        FlagCapture = 156,
        Suicide = 157,
        Artillery = 159,
        EnterVehicle = 200,
        ChangeVehicleSeat = 201,
        LeaveVehicle = 202,
        PlaceItemOnGround = 400,
        UseItemOnGround = 401,
        GetMission = 402,
        StartMission = 403,
        EnviromentDamage = 500
    }
}
