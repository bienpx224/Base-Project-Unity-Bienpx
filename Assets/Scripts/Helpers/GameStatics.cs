using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameStatics
{
    public static bool IsAnimating = false;
    public static bool IsPause = false;

    public static int IdTileSelect = -1;
    public static bool DarkTheme = false;
    public static bool IsUseBoom = false;
    public static int LevelJump = 0;
    public static bool isOpenMusic = false;
    public static bool isAds = false;
    public static int TimeRevive = 0;
    public static int TimeShowInput = 0;
    public static bool IsOpenMilestone = false;
    public static Sprite SprBanner = null;
    public static int TimeShowRating = 0;

    public static int TimeOfflineEarning = 20;

    public static bool show1 = false;
    public static bool show2 = false;
    public static bool show3 = false;

    public static bool isHasRank = true;

    public static bool isAlreadyAskUpdateNewVersion = false;

    public static bool IsCombat = false;
    public static bool IsCanContactHero = true;
    public static bool IsInitFirebase = false;

    public static bool isIntroduceSkill = false;

    public static int IsDownloadDone = 0;

    public static JSONObject BATTLE_DATA;
}
