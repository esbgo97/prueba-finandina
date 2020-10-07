namespace AppRepository
{
    public struct Queries
    {
        public struct Client
        {
            public static string CREATE = "[dbo].[CREATE_CLIENT]";
            public static string UPDATE = "[dbo].[UPDATE_CLIENT]";
            public static string DELETE = "[dbo].[DELETE_CLIENT]";
            public static string UPDATE_STATE = "[dbo].[UPDATE_CLIENT_STATE]";
            public static string GET_ALL = "[dbo].[GET_ALL_CLIENTS]";
        }
    }
}
