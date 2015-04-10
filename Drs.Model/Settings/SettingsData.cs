﻿using System.Collections.Generic;
using Autofac;
using Drs.Model.Constants;
using Drs.Model.Shared;

namespace Drs.Model.Settings
{
    public static class SettingsData
    {

        public static class Constants
        {
            public const string EXTENSION_EXE = ".exe";
            public const string SETTING_SEPARATOR = "|";
            
            public static AddressControlSetting AddressUpsertSetting { get; set; }
            public static AddressControlSetting AddressGridSetting { get; set; }


            public static class Entities
            {
                public const int NULL_ID_INT = -1;
            }

            public static class Group
            {
                public const string FRANCHISE = "FRANCHISE";
                public const string SYSTEM = "SYSTEM";
                public const string SERVER = "SERVER";
                public const string CLIENT = "CLIENT";
                public const string STORE = "STORE";
                public const string TRACK = "TRACK";
            }

            public static class SystemConst
            {
                public const string MINUTES_TO_BE_FUTURE_ORDER = "MINUTES_TO_BE_FUTURE_ORDER";
                public const string SECONDS_TO_ASK_FOR_STATUS_ORDER = "SECONDS_TO_ASK_FOR_STATUS_ORDER";
                public const string ALOHA_IBER_TO_INIT = "ALOHA_IBER_TO_INIT";
                public const string ALOHA_IBER = "ALOHA_IBER";
                public const string ALOHA_PATH = "ALOHA_PATH";
                public const string LANGUAGE = "LANGUAGE";
                public const string CULTURE_SYSTEM = "CULTURE_SYSTEM";

                public const string CULTURE_SYSTEM_DEFAULT = "en-US";
                public const string FORMAT_DATETIME_V1 = "dddd, dd/MMMM/yyyy HH:mm";
                public const bool FALSE = false;
                public const bool TRUE = true;
            }
            
            public static class ServerConst
            {
                public const string MAX_RESULTS_ON_QUERY = "MAX_RESULTS_ON_QUERY";
            }
            
            public static class ClientConst
            {
                public const string TOTAL_SECONDS_TO_LOGOUT = "TOTAL_SECONDS_TO_LOGOUT";
                public const string MIN_LENGTH_PHONE = "MIN_LENGTH_PHONE";
            }

            public static class Control
            {
                public const string CONTAINER_GRID_ADDRESS = "GRID_ADDRESS";
                public const string CONTAINER_UPSERT_ADDRESS = "UPSERT_ADDRESS";

                public const string CONTROL_COUNTRY = "COUNTRY";
                public const string CONTROL_REGION_A = "REGION_A";
                public const string CONTROL_REGION_B = "REGION_B";
                public const string CONTROL_REGION_C = "REGION_C";
                public const string CONTROL_REGION_D = "REGION_D";
                public const string CONTROL_MAIN_ADDRESS = "MAIN_ADDRESS";
                public const string CONTROL_REFERENCE = "REFERENCE";
                public const string CONTROL_NUM_EXT = "NUM_EXT";
                public const string CONTROL_ZIP_CODE = "ZIP_CODE";
                public const string CONTROL_FIRST_ADDRESS = "FIRST_ADDRESS";
                public const string CONTROL_LAST_ADDRESS = "LAST_ADDRESS";

            }

            public static class Franchise
            {
                public const string ALOHA_IBER_TO_INIT = "Iber.exe";
                public const string ALOHA_PATH = @"C:\BootDrv\Aloha";
                public const string ALOHA_IBER = @"Iber.exe";
                public const string DATA_FOLDER = "DATA";
                public const string NEWDATA_FOLDER = "NEWDATA";
                public const string TMP_FOLDER = "TMP";
                public const string STOP_FILE = "STOP";
                public const string BIN_FOLDER = "BIN";
            }

            public class StoreConst
            {
                public const string QUANTITY_ITEM = "1";
                public const string SENDING_MODE_DELIVERY = "Delivery";

                public const int MODE_DELIVERY_IMMEDIATE = 500;
                public const int MODE_DELIVERY_FUTURE = 501;

                public const string BY_COUNTRY = "BY_COUNTRY";
                public const string BY_REGIONA = "BY_REGIONA";
                public const string BY_REGIONB = "BY_REGIONB";
                public const string BY_REGIONC = "BY_REGIONC";
                public const string BY_REGIOND = "BY_REGIOND";
                public const string BY_ZIPCODE = "BY_ZIPCODE";

                public const int STORE_RESPONSE_ORDER_ERROR = 1100;
                
                public const int STORE_RESPONSE_CALL_WS_ERROR = 1101;
                public const int STORE_RESPONSE_CALL_WS_SUCCESS = 1102;
                public const int STORE_RESPONSE_PING_ERROR = 1103;
                public const int STORE_RESPONSE_PING_OK = 1104;
                public const int STORE_RESPONSE_FAILURE = 1105;
                public const int STORE_RESPONSE_ORDER_OK = 1106;

                public const int STORE_RESPONSE_PING_WS_OK = 1010;
            }

            public static class StoreOrder
            {
                public static string WsCustomerOrder = "CustomerOrder/CustomerOrder";
                public static string WsQueryFunction = "QueryFunction/QueryFunction";
                
                public const int MINUTES_TO_BE_FUTURE_ORDER = 60;
            }

            public class TrackConst
            {
                public const int SECONDS_TO_ASK_FOR_STATUS_ORDER = 180;
                public const int SEARCH_ORDERLIST_ON_PROGRESS = 3100;
                public const int SEARCH_ORDERLIST_READY = 3101;
                public const int SEARCH_ERROR_PHONE =3102;
                public const int SEARCH_ORDERLIST_OK = 3013;
                public const int SEARCH_SHOWDETAIL_ON_PROGRESS = 3014;
                public const int SEARCH_SHOWDETAIL_OK = 3015;
                public const int SEARCH_SHOWDETAIL_ERROR = 3016;

                public const string NONE = "None";
                public const string PRE_DELAY = "PreDelay";
                public const string IN_DELAY = "InDelay";
                public const string KITCHEN_DELAY = "KitchenDelay";
                public const string COOKING = "Cooking";
                public const string PREPARED = "Prepared";
                public const string IN_TRANSIT = "InTransit";
                public const string FULFILLED = "Fulfilled";
                public const string CLOSED = "Closed";

                public static Dictionary<string, string> LstOrderStatus = new Dictionary<string, string>
                {
                    { OrderStatus.NEW_READY_TO_SEND, "Orden para enviar a la tienda" },
                    { NONE, "Nueva orden" },
                    { PRE_DELAY, "Nueva orden orden futura" },
                    { IN_DELAY, "Orden retrasada (orden futura)" },
                    { KITCHEN_DELAY, "Orden retrasada en cocina" },
                    { COOKING, "Preparando orden en cocina" },
                    { PREPARED, "Preparando la orden" },
                    { IN_TRANSIT, "Orden en camino al cliente" },
                    { FULFILLED, "Orden entregada al cliente" },
                    { CLOSED, "Orden cerrada" }
                }; 

            }
        }

        public static class Server
        {
            public static int MaxResultsOnQuery = 50;
        }


        public static class Client
        {
            public static int TotalSecondsToLogOut = 600;
            public static int MinLengthPhone = 5;
            public static IContainer Container;
            public static double SencondsToWaitForResponse = 90;
            public static double SencondsToDetectStale = 70;
        }

        public static int Language = 1;
        public static string FirstRegion = Constants.Control.CONTROL_COUNTRY;
        public static string LastRegion = Constants.Control.CONTROL_REGION_C;
        public static string AlohaPath = Constants.Franchise.ALOHA_PATH;
        public static string AlohaIber = Constants.Franchise.ALOHA_IBER;
        public static string AlohaIberToInit = Constants.Franchise.ALOHA_IBER_TO_INIT;
        public static int SecondsToAskForStatusOrder = Constants.TrackConst.SECONDS_TO_ASK_FOR_STATUS_ORDER;
        public static int MinutesToBeFutureOrder = Constants.StoreOrder.MINUTES_TO_BE_FUTURE_ORDER;
        public static string CultureSystem = Constants.SystemConst.CULTURE_SYSTEM_DEFAULT;

        public class Store
        {
            public static bool ByCountry { get; set; }
            public static bool ByRegionA { get; set; }
            public static bool ByRegionB { get; set; }
            public static bool ByRegionC { get; set; }
            public static bool ByRegionD { get; set; }
            public static bool ByZipCode { get; set; }
        }

    }

}