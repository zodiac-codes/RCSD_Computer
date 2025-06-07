using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCSD_Computer
{
    public static class Templates
    {
        // BB code templates for forums.
        // Program will replace OUTPUT_x with user input.

        public static string IncidentTemplate = @"
[divbox=white][pad=5]

[TABLE]
[TR][TDW][pady=5][SEAL3=100][/SEAL3][/pady]

[INDENT=1][color=white]....[/color][b]Form[/b]
RCSD-IR-485[/indent][/TDW] [TDW][b][size=150]Red County Sheriff's Department[/size]
[size=200]Incident Report[/size][/tdw]

[tdw][divbox=white][b]Incident Number:[/b]
{OUTPUT_1}
[/divbox]

[divbox=white][b]Date of Report:[/b]
{OUTPUT_2}

[/divbox][/tdw][/TR][/TABLE]

[TABLE]
[tr][tdc=black][size=120][b][color=white]INCIDENT INFORMATION[/color][/b][/size][/tdc][tdc=black][/tdc][tdc=black][/tdc]
[TR][TDW][b]Incident Type:[/b]
{OUTPUT_3}[/TDW]

[TDW][b]Initiation:[/b]
{OUTPUT_4}[/TDW]

[TDW][b]Time of Incident:[/b]
{OUTPUT_5}
[/tdw][/TR]

[TR][tdw][b]Location of Incident:[/b]
{OUTPUT_6}[/tdw]

[tdw][b]Gang Related:[/b]
{OUTPUT_7}[/tdw]

[tdw][b]Incident Commander:[/b]
{OUTPUT_8}[/tdw]

[/TR][/TABLE]

[TABLE]
[TR][tdc=black][color=white][b][size=120]DEPUTY INFORMATION[/size][/b][/color][/tdc][tdc=black][/tdc][tdc=black][/tdc]
[/TR]
[TR][tdw][b]Deputy Name:[/b]
{OUTPUT_9}[/tdw]

[tdw][b]Rank:[/b]
{OUTPUT_10}[/tdw]

[tdw][b]Assignment:[/b]
{OUTPUT_11}
[/tdw][/tr]

[TR]
[tdw][b]Deputy Callsign:[/b]
{OUTPUT_12}
[/tdw]

[tdw][b]Responding Agencies:[/b]
{OUTPUT_13}[/tdw]

[/TR][/TABLE]
[color=white]..[/color]
[TABLE]
[TR][tdc=black][color=white][size=120][b]INCIDENT NARRATIVE[/b][/size][/color][/tdc][tdc=black][/tdc][tdc=black][/tdc][/TR][/TABLE]

[TABLE][TR][td]
{OUTPUT_14}
[/td][/TABLE]
[color=white].[/color]
[TABLE][TR][tdw][b]Signing Deputy:[/b] {OUTPUT_15}[/tdw]
[tdw][b]Badge Number[/b]: {OUTPUT_16}

[tdw][b]Dated:[/b] {OUTPUT_17}[/tdw]
[/TR]

[TR][tdw][b]Signature:[/b]
[yimg=60]{OUTPUT_18}[/yimg]

[/tdw][/TR]
[/TABLE]

[/pad][/divbox]";

        public static string ArrestTemplate = @"[divbox=white][pad=5]

[TABLE][TR][TDW][pady=5][SEAL3=100][/SEAL3][/pady]
[indent=1][color=white]....[/color][b]Form[/b][/indent]
[indent=1]RCSD-IR-225[/indent][/TDW]
[tdw][CENTER][size=150][b]Red County Sheriff's Department[/b][/size]
[b][size=200]Subject Arrest Report[/size][/b][/CENTER][/tdw]

[tdw][color=white].[/color][/tdw][tdw][color=white].[/color][/tdw][tdw][color=white].[/color][/tdw][tdw][color=white].[/color][/tdw]
[/TR][/TABLE]

[right][padx=10][b]Date of Arrest:[/b] {OUTPUT_1}[/padx][/right]
[TABLE]
[TR][td][b][size=120]SUBJECT INFORMATION[/size][/b][/td][/TR][/TABLE]

[TABLE]
[TR][td][b]Firstname:[/b]
{OUTPUT_2}[/td]

[td][b]Lastname:[/b]
{OUTPUT_3}[/td]

[td][b]Gender:[/b]
{OUTPUT_4}[/td]

[td][b]Date of Birth:[/b]
{OUTPUT_5}[/td][/TR]

[TR][td][b]Race:[/b]
{OUTPUT_6}[/td]

[td][b]Aliases:[/b]
{OUTPUT_7}[/td]

[td][b]Classification:[/b]
{OUTPUT_8}[/td]

[td][b]Gang Affiliation:[/b]
{OUTPUT_9}[/td][/TR][/TABLE]

[TABLE][TR][td][b]Charges:[/b]
{OUTPUT_10}[/td]

[td][b]Supplementary Reports:[/b]
{OUTPUT_11}[/td]

[/TR][/TABLE]
[color=white]_[/color]
[table][TR][tdc=black][color=white][size=120][b]ARREST NARRATIVE[/b][/size][/color][/tdc][/TR]

[/table]
[divbox2=white,white][table][tr][tdw][b]Location of Arrest:[/b] {OUTPUT_12}[/tdw][tdw][b]Time of Arrest:[/b] {OUTPUT_13}[/tdw][/tr][/table][/divbox2]
[table][tr][tdw]{OUTPUT_14}[/tdw][/tr][/table]
[hr3=15][/hr3]

[TABLE][tr][tdw][b]Arresting Deputy:[/b]
{OUTPUT_15}[/tdw] [tdw][b]Rank[/b]:
{OUTPUT_16}[/tdw] [tdw][b]Badge Number:[/b]
{OUTPUT_17}[/tdw] [tdw][b]Assignment:[/b]
{OUTPUT_18}[/tdw][/tr]
[tr][tdw][b]Signature:[/b]
[yimg=60]{OUTPUT_19}[/yimg][/tdw][/tr]

[/TABLE]

[/pad][/divbox]";

        public static string SeizureTemplate = @"[divbox=white]
[TABLE][TR][tdw][SEAL3=120][/SEAL3][/tdw]
[tdw][CENTER][b]Red County Sheriff's Deparmtent
Records Division
Property and Evidence Bureau

[b][size=150]EVIDENCE SUBMISSION FORM[/size][/b][/CENTER][/tdw]
[tdw][RIGHT][fimg=120,120]https://i.imgur.com/WWnY8F0.png[/fimg][/RIGHT][/tdw][/TR][/TABLE]
[pady=10][padx=25][center][size=85]All property and evidence submitted must be properly tagged, packaged, and accompanied by this completed form. Submitting personnel are responsible for ensuring the accuracy of all listed information. Incomplete, illegible, or improperly submitted evidence may be rejected or returned. This form constitutes the initial entry in the chain of custody. Once submitted, custody and control of the listed items are transferred to the Property & Evidence Bureau in accordance with departmental policy.[/size][/center][/padx][/pady]
[pad=5]

[TABLE][TR][TD][b]Classification:[/b]
{OUTPUT_1}[/TD]

[TD][b]If Others:[/b]
{OUTPUT_2} [/TD]
[/TR][/TABLE]

[TABLE][TR][tdc=black][color=white][size=120][b]EVIDENCE INVENTORY[/b][/size][/color][/tdc][/TR]
[TR][td]{OUTPUT_3}
[/td][/TR][/TABLE]

[pady=8][pad=5][b]Circumstances of Seizure:[/b]
{OUTPUT_4}

[pady=5][pad=5][b]Supplementary Reports:[/b]
{OUTPUT_5}[/pad][/pady]

[hr3=15][/hr3]

[TABLE][TR]
[TDW][b]Deputy Name:[/b]
{OUTPUT_6}[/TDW]
[TDW][b]Deputy Rank:[/b]
{OUTPUT_7}[/TDW]
[TDW][b]Badge Number:[/b]
{OUTPUT_8}[/TDW]
[TDW][/TDW]

[/TR]
[TR][TDW][b]Signature:[/b]
{OUTPUT_9}[/TDW]
[TDW][b]Dated:[/b]
{OUTPUT_10}[/TDW]
[/TR]

[/TABLE]

[/pad][/divbox]";
    }

}

