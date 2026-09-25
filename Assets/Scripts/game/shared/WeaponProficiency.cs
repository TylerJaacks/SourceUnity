using System.Collections.Generic;

namespace Game.Shared
{
    struct WeaponProficiencyInfo_t
    {
        float spreadScale;
        float bias;
    };

    enum WeaponProficiency_t
    {
        WEAPON_PROFICIENCY_POOR = 0,
        WEAPON_PROFICIENCY_AVERAGE,
        WEAPON_PROFICIENCY_GOOD,
        WEAPON_PROFICIENCY_VERY_GOOD,
        WEAPON_PROFICIENCY_PERFECT,
    };

    class WeaponProficiency
    {
        static List<string> g_ProficiencyNames = new()
        {
            "Poor",
            "Average",
            "Good",
            "Very Good",
            "Perfect"
        };

        static string GetWeaponProficiencyName(WeaponProficiency_t proficiency)
        {
            if (proficiency < 0 || proficiency > WeaponProficiency_t.WEAPON_PROFICIENCY_PERFECT)
                return "<<Invalid>>";
            return g_ProficiencyNames[(int)proficiency];
        }
    }
}