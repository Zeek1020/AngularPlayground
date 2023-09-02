using Microsoft.Data.SqlClient;

namespace AngularPlayground.Controllers
{
    /// <summary>
    /// Do not use a singleton to access DB. Use a resource pool to handle multiple concurrent DB connections
    /// </summary>
    public static class DatabaseConnection
    {
        
    }
}
