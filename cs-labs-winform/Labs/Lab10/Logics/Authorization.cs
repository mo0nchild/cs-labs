using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable SYSLIB0011 // Тип или член устарел
namespace CSharpLabs.Lab10.Logics
{
    public interface IProfileAuthorization<TProfileData>
    {
        public System.Guid Authorization(System.String keyfilepath);
        public System.Guid Authorization(System.String login, System.String password);

        public System.Guid Registration(TProfileData profile);
        public TProfileData GetProfileRecord(System.Guid profile_id);
    }

    public sealed class ProfileAuthorizationException : System.Exception
    {
        public ProfileAuthorizationException(string message) : base(message) { }
    }

    public class ProfileAuthorization : System.Object, IProfileAuthorization<ProfileModel>
    {
        public virtual string ProfilesDirectory { get => @".\employees"; }

        public Guid Authorization(string login, string password)
        {
            ProfileModel? profileModel = new ProfileModel();
            foreach (var filePath in Directory.GetFiles(this.ProfilesDirectory))
            {
                try {
                    using (var fileStream = File.OpenRead(@$"{filePath}"))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        profileModel = formatter?.Deserialize(fileStream)! as ProfileModel;

                        if (profileModel!.Login == login && profileModel.Password == password)
                        {
                            return profileModel.Key;
                        }
                    }
                }
                catch { continue; }
                
            }
            return Guid.Empty;
        }

        public Guid Authorization(string keyfillepath)
        {
            if (!File.Exists($@"{keyfillepath}")) return Guid.Empty;
            using (var fileStream = new BinaryReader(File.OpenRead(@$"{keyfillepath}")))
            {
                try { return Guid.Parse(fileStream.ReadString()); } catch { return Guid.Empty; }
            }
        }

        public ProfileModel GetProfileRecord(Guid profile_id)
        {
            var filepath = $@"{this.ProfilesDirectory}\{profile_id}.profile";
            if (!File.Exists(filepath)) throw new ProfileAuthorizationException("Профиля не существует");

            using (FileStream filereader = File.OpenRead(filepath))
            { return (ProfileModel) new BinaryFormatter().Deserialize(filereader); }
        }

        public Guid Registration(ProfileModel profile)
        {
            var directorypath = @$"{this.ProfilesDirectory}";
            if (!Directory.Exists(directorypath)) Directory.CreateDirectory(directorypath);

            foreach(var filepath in Directory.GetFiles(directorypath))
            {
                try {
                    var profile_id = Guid.Parse(Path.GetFileNameWithoutExtension(filepath));
                    if (profile.Equals(this.GetProfileRecord(profile_id)))
                    {
                        throw new ProfileAuthorizationException("Профиль уже создан");
                    }
                }
                catch (ProfileAuthorizationException) { throw; } catch (System.Exception) { continue; }
            }
            var newprofile_id = profile.Key;
            using (var filestream = File.Create(@$"{this.ProfilesDirectory}\{newprofile_id}.profile"))
            {
                new BinaryFormatter().Serialize(filestream, profile);
            }
            using (var writter = new BinaryWriter(File.Create(@$"{this.ProfilesDirectory}\{profile.Login}.key")))
            { writter.Write(newprofile_id.ToString()); }

            return newprofile_id;
        }
    }
}
#pragma warning restore SYSLIB0011 // Тип или член устарел