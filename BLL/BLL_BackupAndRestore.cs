using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn_ver5.DAL;

namespace DoAn_ver5.BLL
{
    class BLL_BackupAndRestore
    {
        private static BLL_BackupAndRestore _Instance;
        public static BLL_BackupAndRestore Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_BackupAndRestore();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        public bool Backup(string browse)
        {
            return DataProvider.Instance.Backup(browse);
        }

        public bool Restore(string browse)
        {
            return DataProvider.Instance.Restore(browse);
        }

    }
}
