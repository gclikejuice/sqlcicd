using sqlcicd.Database.Entity;

namespace sqlcicd.Repository.Entity
{
    /// <summary>
    /// Repository version
    /// </summary>
    public class RepositoryVersion
    {
        public RepositoryVersion(string version)
        {
            Version = version;
        }

        /// <summary>
        /// Version id
        /// </summary>
        public string Version { get; private set; }

        /// <summary>
        /// Get a <see cref="RepositoryVersion" /> instance from <see cref="SqlVersion" />
        /// </summary>
        public static RepositoryVersion GetRepositoryVersion(SqlVersion sv)
        {
            if (sv == null || string.IsNullOrEmpty(sv.Version))
            {
                return null;
            }
            else
            {
                return new RepositoryVersion(sv.Version);                
            }
        }
    }
}