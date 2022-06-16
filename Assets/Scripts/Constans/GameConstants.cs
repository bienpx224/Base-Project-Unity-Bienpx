using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameConstants
{
    public const int SNAP_X = 69;
    public const int SNAP_Y = 35;

    public readonly static float TRANSLATE_SNAP_X = SNAP_X / 1000f;
    public readonly static float TRANSLATE_SNAP_Y = SNAP_Y / 1000f;
    public readonly static int LAYER_BUILDING_MASK = 1 << LayerMask.NameToLayer("Building");
    public readonly static int LAYER_IGNORE_TOUCH = 1 << LayerMask.NameToLayer("IgnoreTouch");
    public readonly static string[] CATEGORY_LIST = new string[] { "buni house", "breeding house", "mentoring house", "farm", "hatchery", "temple", "training center" };
    #region LOGIN AUTH
    public const string ACCESS_TOKEN_REF = "access_token";
    public const string EXPIRE_TOKEN_REF = "expire_token";
    public const string REFRESH_TOKEN_REF = "refresh_token";
    public const string USER_NAME = "user_name";
    public const string URL_CREATE_ACCOUNT_IN_WEB = "https://islands.bunicorn.game/";
    public const string URL_FORGOT_ACCOUNT_IN_WEB = "https://islands.bunicorn.game/";
    public const string URL_GAME_IN_WEB = "https://islands.bunicorn.game/";
    public const string HOST = "https://buni-dev-api.sotatek";  // Official
    public const string API_LOGIN_USERPASS = "https://buni-dev-api.sotatek.works";
    public const string API_REFRESH_ACCESSTOKEN = "https://buni-dev-api.sotatek.works";
    public const string API_LOGIN_WALLET = "https://buni-dev-api.sotatek.works";  // Offcial 
    #endregion
    #region ENUM_SIGN_IN
    public const int READY_SIGN = 0;
    public const int SIGNING_IN = 1;
    public const int SIGNED_IN = 2;
    #endregion
    #region ENUM_ADD_SHOW_TYPE
    public const int SHOW_TYPE_BUNI = 0;
    public const int SHOW_TYPE_TRAINER = 1;
    #endregion

    #region ENUM_FEE_TYPE
    public const int FEE_TYPE_BUNI = 5;
    public const int FEE_TYPE_FOOD = 4;
    public const int FEE_TYPE_BUR = 1;
    public const int FEE_TYPE_GOLD_SMALL = 2;
    public const int FEE_TYPE_GOLD = 3;
    #endregion

    public const int SELECT_TYPE_IDLE = 2;
    public const int SELECT_TYPE_CHOSING = 1;
    public const int SELECT_TYPE_FREE = 0;


    public const int MAIN_UI_MODE_MAIN = 0;
    public const int MAIN_UI_MODE_YES_NO = 1;
    public const int MAIN_UI_MODE_PROCESS_BUILDING = 2;
    public const int MAIN_UI_MODE_MAIN_BUTTON = 3;

    public const float ORIGINAL_OTHORSIZE = 1.4f;
    public const string ENUM_FARM_TYPE = "farm";
    public const string ENUM_BUNIHOUSE_TYPE = "bunihouse";
    public const string ENUM_TRAININGCENTER_TYPE = "trainingcenter";
    public const string ENUM_TEMPLE_TYPE = "temple";
    public const string ENUM_BREEDING_HOUSE_TYPE = "breedinghouse";
    public const string ENUM_HATCHERY_TYPE = "hatchery";
    public const string ENUM_STORAGE_TYPE = "storage";
    public const string ENUM_MENTORING_TYPE = "mentoring";

    public const string BATTLE_SLOT_1 = "battle_slot_1";
    public const string BATTLE_SLOT_2 = "battle_slot_2";
    public const string BATTLE_SLOT_3 = "battle_slot_3";

    public const string DEFEND_SLOT_1 = "defend_slot_1";
    public const string DEFEND_SLOT_2 = "defend_slot_2";
    public const string DEFEND_SLOT_3 = "defend_slot_3";


    public const string STEAL_SLOT_1 = "steal_slot_1";
    public const string STEAL_SLOT_2 = "steal_slot_2";
    public const string STEAL_SLOT_3 = "steal_slot_3";

    public const string ELEMENT_FIRE = "Sprite/BuniInfoElement/fire";
    public const string ELEMENT_EARTH = "Sprite/BuniInfoElement/earth";
    public const string ELEMENT_WATER = "Sprite/BuniInfoElement/water";
    public const string ELEMENT_AIR = "Sprite/BuniInfoElement/air";
    public enum TypeElement
    {
        unknow,
        water,
        fire,
        earth,
        air
    }

}
public enum TypeHero
{
    All = -1,
    Cat = 0,
    Monkey = 1
}
public enum TypeBuilding
{
    Farm,
    BuniHouse
}
