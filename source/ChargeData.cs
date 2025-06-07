using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCSD_Computer
{
    public class Charge
    {

        // Laws storage (from Penal Code)
        // Code = Section
        // Title = Law Name
        // Classification = Felony/Misdemeanor

        public string Code { get; set; }
        public string Title { get; set; }
        public string Classification { get; set; }

        public string Display => Title;
    }

    public static class ChargeData
    {
        public static List<Charge> Charges = new List<Charge>
        {
            // CRIMES AGAINST THE PERSON
new Charge { Code = "§101.", Title = "Assault", Classification = "M" },
            new Charge { Code = "§101.3", Title = "Aggravated Assault", Classification = "M" },
            new Charge { Code = "§102.", Title = "Assault with a Deadly Weapon", Classification = "F" },
            new Charge { Code = "§102.4", Title = "Aggravated Assault with a Deadly Weapon", Classification = "F" },
            new Charge { Code = "§103.", Title = "Battery", Classification = "M" },
            new Charge { Code = "§103.3", Title = "Aggravated Battery", Classification = "M" },
            new Charge { Code = "§104.", Title = "Battery with a Deadly Weapon", Classification = "F" },
            new Charge { Code = "§104.4", Title = "Aggravated Battery with a Deadly Weapon", Classification = "F" },
            new Charge { Code = "§105.1", Title = "Murder (First Degree)", Classification = "F" },
            new Charge { Code = "§105.2", Title = "Murder (Second Degree)", Classification = "F" },
            new Charge { Code = "§106.1", Title = "Attempted Murder (First Degree)", Classification = "F" },
            new Charge { Code = "§106.2", Title = "Attempted Murder (Second Degree)", Classification = "F" },
            new Charge { Code = "§107.1", Title = "Voluntary Manslaughter", Classification = "F" },
            new Charge { Code = "§107.2", Title = "Involuntary Manslaughter", Classification = "F" },
            new Charge { Code = "§107.3", Title = "Vehicle Manslaughter (Misdemeanor)", Classification = "M" },
            new Charge { Code = "§107.3", Title = "Vehicle Manslaughter (Felony)", Classification = "F" },
            new Charge { Code = "§108.", Title = "False Imprisonment", Classification = "F" },
            new Charge { Code = "§109.", Title = "Kidnapping", Classification = "F" },
            new Charge { Code = "§110.", Title = "Human Trafficking", Classification = "F" },
            new Charge { Code = "§111.", Title = "Rape", Classification = "F" },
            new Charge { Code = "§112.", Title = "Sexual Assault", Classification = "M" },
            new Charge { Code = "§113.", Title = "Sexual Battery", Classification = "F" },
            new Charge { Code = "§114.", Title = "Robbery", Classification = "F" },
            new Charge { Code = "§115.", Title = "Armed Robbery", Classification = "F" },
            new Charge { Code = "§116.", Title = "Torture", Classification = "F" },
            new Charge { Code = "§117.", Title = "Stalking", Classification = "M" },
            new Charge { Code = "§118.", Title = "Mutual Combat", Classification = "M" },
            new Charge { Code = "§119.", Title = "Intimidation", Classification = "M" },
            new Charge { Code = "§120.1", Title = "Identity Theft (Misdemeanor)", Classification = "M" },
            new Charge { Code = "§120.2", Title = "Identity Theft (Felony)", Classification = "F" },
            new Charge { Code = "§121.3", Title = "Violation of Civil Rights", Classification = "M" },

            //CRIMES AGAINST THE PROPERTY
            new Charge { Code = "§201.", Title = "Trespassing", Classification = "M" },
            new Charge { Code = "§202.", Title = "Trespassing on Government Property", Classification = "M" },
            new Charge { Code = "§203.", Title = "Burglary", Classification = "F" },
            new Charge { Code = "§204.1", Title = "Arson (First Degree)", Classification = "F" },
            new Charge { Code = "§204.2", Title = "Arson (Second Degree)", Classification = "F" },
            new Charge { Code = "§205.", Title = "Petty Theft", Classification = "M" },
            new Charge { Code = "§206.", Title = "Grand Theft", Classification = "F" },
            new Charge { Code = "§207.", Title = "Vandalism", Classification = "M" },
            new Charge { Code = "§208.", Title = "Embezzlement", Classification = "F" },
            new Charge { Code = "§209.", Title = "Fraud", Classification = "F" },
            new Charge { Code = "§210.", Title = "Forgery", Classification = "F" },
            new Charge { Code = "§211.", Title = "Extortion", Classification = "F" },
            new Charge { Code = "§212.", Title = "Racketeering", Classification = "F" },
            new Charge { Code = "§213.", Title = "Receiving Stolen Property", Classification = "M" },
            new Charge { Code = "§214.", Title = "Cybercrime (Misdemeanor)", Classification = "M" },
            new Charge { Code = "§214.7", Title = "Cybercrime (Felony)", Classification = "F" },

            //CRIMES AGAINST PUBLIC JUSTICE
            new Charge { Code = "§301.", Title = "Obstruction of Justice", Classification = "F" },
            new Charge { Code = "§302.", Title = "Tampering with Evidence", Classification = "F" },
            new Charge { Code = "§303.", Title = "Bribery of a Public Official", Classification = "F" },
            new Charge { Code = "§304.", Title = "Misconduct of Office", Classification = "F" },
            new Charge { Code = "§305.", Title = "Perjury", Classification = "F" },
            new Charge { Code = "§306.", Title = "Evading", Classification = "F" },
            new Charge { Code = "§307.", Title = "Resisting Arrest", Classification = "M" },
            new Charge { Code = "§308.", Title = "Prison Break", Classification = "F" },
            new Charge { Code = "§309.", Title = "Unlawful Rescue", Classification = "F" },
            new Charge { Code = "§310.", Title = "Failure to Identify", Classification = "M" },
            new Charge { Code = "§311.", Title = "Introduction of Contraband", Classification = "F" },
            new Charge { Code = "§312.", Title = "Aggravated Evading", Classification = "F" },

            //CRIMES AGAINST THE STATE
            new Charge { Code = "§401.", Title = "Treason", Classification = "F" },
            new Charge { Code = "§402.", Title = "Espionage", Classification = "F" },
            new Charge { Code = "§403.", Title = "Sedition", Classification = "F" },
            new Charge { Code = "§404.", Title = "Terrorism", Classification = "F" },
            new Charge { Code = "§405.", Title = "Terroristic Threats", Classification = "F" },
            new Charge { Code = "§406.", Title = "Contempt of Court", Classification = "M" },
            new Charge { Code = "§407.", Title = "Impersonation of a Public Servant", Classification = "M" },
            new Charge { Code = "§408.", Title = "Failure to Pay a Fine", Classification = "M" },

            //TRAFFIC VIOLATIONS
            new Charge { Code = "§502.", Title = "Reckless Driving", Classification = "M" },
            new Charge { Code = "§503.", Title = "Driving Without a License", Classification = "M" },
            new Charge { Code = "§506.", Title = "Driving Under Influence", Classification = "M" },
            new Charge { Code = "§511.", Title = "Super-Speeding", Classification = "M" },
            new Charge { Code = "§513.", Title = "Street Racing", Classification = "M" },
            new Charge { Code = "§517.", Title = "Hit and Run", Classification = "M" },
            new Charge { Code = "§518.", Title = "Felony Hit and Run", Classification = "F" },

            //CRIMES AGAINST PUBLIC HEALTH AND SAFETY
            new Charge { Code = "§601.1", Title = "Possession of a Controlled Substance", Classification = "M" },
            new Charge { Code = "§602.", Title = "Possession with the Intent to Distribute (Felony)", Classification = "F" },
            new Charge { Code = "§602.3", Title = "Possession with the Intent to Distribute (Misdemeanor)", Classification = "M" },
            new Charge { Code = "§603.", Title = "Distribution of a Controlled Substance", Classification = "F" },
            new Charge { Code = "§604.", Title = "Manufacture of a Controlled Substance", Classification = "F" },
            new Charge { Code = "§607.", Title = "Furnishing Alcohol to an Underage Person", Classification = "M" },
            new Charge { Code = "§608.", Title = "Possession of Drug Paraphernalia", Classification = "M" },
            new Charge { Code = "§609.", Title = "Smuggling of Contraband", Classification = "F" },

            //CRIMES AGAINST THE PUBLIC
            new Charge { Code = "§701.", Title = "Disorderly Conduct", Classification = "M" },
            new Charge { Code = "§702.", Title = "Unlawful Assembly", Classification = "M" },
            new Charge { Code = "§703.", Title = "Littering", Classification = "M" },
            new Charge { Code = "§704.", Title = "Abuse of a Corpse", Classification = "M" },
            new Charge { Code = "§706.", Title = "Misuse of an Emergency Hotline", Classification = "M" },
            new Charge { Code = "§707.", Title = "Indecent Exposure", Classification = "M" },
            new Charge { Code = "§708.", Title = "Illicit Gambling Practices", Classification = "M" },
            new Charge { Code = "§709.", Title = "Illicit Liquor Practices", Classification = "M" },
            new Charge { Code = "§710.", Title = "Reckless Endangerment", Classification = "M" },
            new Charge { Code = "§711.", Title = "Riot", Classification = "F" },
            new Charge { Code = "§712.", Title = "Public Corruption", Classification = "F" },
            new Charge { Code = "§713.", Title = "Piracy", Classification = "F" },
            new Charge { Code = "§714.", Title = "Prostitution", Classification = "M" },
            new Charge { Code = "§715.", Title = "Pimping", Classification = "F" },

            //WEAPON AND FIREARM VIOLATIONS
            new Charge { Code = "§801.", Title = "Brandishing a Firearm", Classification = "M" },
            new Charge { Code = "§802.", Title = "Discharging a Firearm in Public", Classification = "M" },
            new Charge { Code = "§803.", Title = "Unlicensed Possession of a Deadly Weapon", Classification = "M" },
            new Charge { Code = "§804.", Title = "Possession of an Unlicensed Firearm", Classification = "M" },
            new Charge { Code = "§805.", Title = "Possession of an Illegal Firearm", Classification = "F" },
            new Charge { Code = "§806.", Title = "Firearm Theft", Classification = "F" },
            new Charge { Code = "§807.", Title = "Firearm Possession with Intent to Distribute", Classification = "F" },
            new Charge { Code = "§808.", Title = "Illegal Firearm Distribution", Classification = "F" },

            //GENERAL PROVISIONS
            new Charge { Code = "§20202.", Title = "Conspiracy", Classification = "F" },
            new Charge { Code = "§20203.", Title = "Aiding and Abetting", Classification = "F" },
            new Charge { Code = "§20204.", Title = "Hate Crime (Misdemeanor)", Classification = "M" },
            new Charge { Code = "§20204.", Title = "Hate Crime (Felony)", Classification = "F" }

        };
    }
}
