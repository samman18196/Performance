using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class JoinLicenseAsset
    {
        [Key]
        public int JoinLicenseAssetID { get; set; }
        public string Status { get; set; }

        [ForeignKey("Location")]
        public int JoinLicenseAsset_License { get; set; }
        public License LicenseID { get; set; }

        [ForeignKey("Asset")]
        public int JoinLicenseAsset_AssetID { get; set; }
        public Asset AssetID { get; set; }
    }
}
