
using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class ChatContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=Db_Chat;Trusted_Connection=True");
            //optionsBuilder.UseSqlServer(@"Server=192.168.16.100;Database=Db_Chat;User Id=1;Password=1;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<GroupMessage>().HasKey(t => t.MessageId);
            modelBuilder.Entity<OperationClaim>().HasKey(t => t.OperationClaimId);
            modelBuilder.Entity<UserOperationClaim>().HasKey(t => t.UserOperationClaimId);
            modelBuilder.Entity<ChatRoomType>().HasKey(t => t.ChatRoomTypeId);
            modelBuilder.Entity<ChatRoom>().HasKey(t => t.ChatRoomId);
            modelBuilder.Entity<GroupAdmin>().HasKey(t => t.GroupAdminId);
            modelBuilder.Entity<GroupMessageStatus>().HasKey(t => t.StatusId);
            modelBuilder.Entity<BlockedUser>().HasKey(t => t.BlockedUserId);
            modelBuilder.Entity<ChatRoomUser>().HasKey(t => t.ChatRoomUserId);
            modelBuilder.Entity<PrivateMessage>().HasKey(t => t.MessageId);
            modelBuilder.Entity<User>().HasKey(t => t.UserId);
            modelBuilder.Entity<UserContact>().HasKey(t => t.UserContactId);
            modelBuilder.Entity<UserDetail>().HasKey(t => t.UserDeatilId);
            modelBuilder.Entity<Post>().HasKey(t => t.PostId);
        }
        public DbSet<User> Users { get; set; }
        //public DbSet<UserVerificationCode> UserVerificationCodes { get; set; }
        public DbSet<BlockedUser> BlockedUsers { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<ChatRoomType> ChatRoomTypes { get; set; }
        public DbSet<ChatRoom> ChatRooms { get; set; }
        public DbSet<ChatRoomUser> ChatRoomUsers { get; set; }
        public DbSet<GroupAdmin> GroupAdmins { get; set; }
        public DbSet<GroupMessage> GroupMessages { get; set; }
        public DbSet<GroupMessageStatus> GroupMessagesStatus { get; set; }
        public DbSet<PrivateMessage> PrivateMessages { get; set; }
        public DbSet<UserContact> UserContacts { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<Post> Posts { get; set; }


    }
}
