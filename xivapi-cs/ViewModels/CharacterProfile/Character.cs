using System.Linq;

namespace xivapi_cs.ViewModels.CharacterProfile
{
    public class Character : CharacterBase
    {
        public Character(DTOs.CharacterProfile.Character dto) : base(dto)
        {
            ActiveClassJob = new ClassJob(dto.ActiveClassJob);
            ClassJobs = dto.ClassJobs.Select(x => new ClassJob(x)).ToArray();
            GearSet = new GearSet(dto.GearSet);
            
            if (dto.GrandCompany != null)
            {
                GrandCompany = new GrandCompany(dto.GrandCompany);
            }

            GuardianDeity = dto.GuardianDeity;
            Race = dto.Race;
            Title = dto.Title;
            Town = dto.Town;
            Tribe = dto.Tribe;
        }

        public ClassJob ActiveClassJob { get; }
        public ClassJob[] ClassJobs { get; }
        public GearSet GearSet { get; }
        public GrandCompany? GrandCompany { get; }
        public int GuardianDeity { get; }
        public int Race { get; }
        public int Title { get; }
        public int Town { get; }
        public int Tribe { get; }
    }
}