using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomGridViewAndTagCloud.Models
{
    public partial class Artist
    {
        public int ArtistId { get; set; } // ArtistId (Primary key)

        public Guid? OldUserId { get; set; } // OldUserId

        public string UserName { get; set; } // UserName

        public string Country { get; set; } // Country

        public string Province { get; set; } // Provence

        public string City { get; set; } // City

        public DateTime CreateDate { get; set; } // CreateDate

        public DateTime ModifiedDate { get; set; } // ModifiedDate

        public string WebSite { get; set; } // WebSite

        public byte ProfilePrivacyLevel { get; set; } // ProfilePrivacyLevel

        public byte ContactPrivacyLevel { get; set; } // ContactPrivacyLevel

        public long ProfileViews { get; set; } // ProfileViews

        public DateTime? ProfileLastViewDate { get; set; } // ProfileLastViewDate

        public byte? Rating { get; set; } // Rating

        public string AvatarUrl { get; set; }

        public string AvatarUrlSample
        {
            get; set;
        }

        public string EmailAddress { get; set; } // EmailAddress

        public int FileUploadsInBytes { get; set; } // FileUploadsInBytes

        public int FileUploadQuotaInBytes { get; set; } // FileUploadQuotaInBytes

        public DateTime LastActivityDate { get; set; } // LastActivityDate

        public bool ShowChatStatus { get; set; } // ShowChatStatus

        public bool AllowChatSounds { get; set; } // AllowChatSounds

        public virtual string Id { get; set; }

        public virtual ICollection<Task> Tasks { get; set; } // Task.FK_Task_Artist

        public Artist()
        {
            CreateDate = DateTime.Now;
            ModifiedDate = System.DateTime.Now;
            ProfilePrivacyLevel = 0;
            ContactPrivacyLevel = 0;
            ProfileViews = 0;
            Rating = 3;
            FileUploadsInBytes = 0;
            FileUploadQuotaInBytes = 0;
            LastActivityDate = System.DateTime.Now;
            ShowChatStatus = true;
            AllowChatSounds = true;
            Id = OldUserId.ToString();
           
        }

     
    }
}
