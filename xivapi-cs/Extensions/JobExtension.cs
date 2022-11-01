using System;
using System.Collections.Generic;
using xivapi_cs.Enums;

namespace xivapi_cs.Extensions;

public static class JobExtension
{
    /// <summary>
    ///     Gets materia priority based on The Balance Discord.
    /// </summary>
    /// <remarks>
    ///     Last updated: 27 Oct 2022
    /// </remarks>
    /// <param name="job">Job to return materia priorities for.</param>
    /// <returns>Array of materia stats, ordered descending by priority.</returns>
    /// <exception cref="ArgumentOutOfRangeException">New job was added, not supported yet.</exception>
    public static IEnumerable<MateriaStat> GetMateriaStats(this Job job)
    {
        switch (job)
        {
            case Job.Pld:
            case Job.War:
            case Job.Drk:
            case Job.Gnb:
                return new[]
                {
                    MateriaStat.CriticalHit,
                    MateriaStat.SkillSpeed,
                    MateriaStat.DirectHitRate,
                    MateriaStat.Determination,
                    MateriaStat.Tenacity
                };
            case Job.Whm:
            case Job.Sch:
            case Job.Ast:
            case Job.Sge:
                return new[]
                {
                    MateriaStat.CriticalHit,
                    MateriaStat.DirectHitRate,
                    MateriaStat.Determination,
                    MateriaStat.SpellSpeed
                };
            case Job.Mnk:
            case Job.Drg:
            case Job.Nin:
            case Job.Sam:
            case Job.Rpr:
            case Job.Brd:
            case Job.Mch:
            case Job.Dnc:
                return new[]
                {
                    MateriaStat.CriticalHit,
                    MateriaStat.Determination,
                    MateriaStat.DirectHitRate,
                    MateriaStat.SkillSpeed
                };
            case Job.Blm:
            case Job.Smn:
            case Job.Rdm:
            case Job.Blu:
                return new[]
                {
                    MateriaStat.CriticalHit,
                    MateriaStat.Determination,
                    MateriaStat.DirectHitRate,
                    MateriaStat.SpellSpeed
                };
            case Job.Crp:
            case Job.Bsm:
            case Job.Arm:
            case Job.Gsm:
            case Job.Ltw:
            case Job.Wvr:
            case Job.Alc:
            case Job.Cul:
                return new[]
                {
                    MateriaStat.Cp,
                    MateriaStat.Craftmanship,
                    MateriaStat.Control
                };
            case Job.Min:
            case Job.Btn:
            case Job.Fsh:
                return new[]
                {
                    MateriaStat.Gp,
                    MateriaStat.Gathering,
                    MateriaStat.Perception
                };
            default:
                throw new ArgumentOutOfRangeException(nameof(job), job, null);
        }
    }
}