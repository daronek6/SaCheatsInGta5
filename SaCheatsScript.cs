using GTA;
using System;
using System.Windows.Forms;

namespace SaCheats
{
    public class SaCheatsScript : Script
    {
        private ModSoundPlayer modSoundPlayer;
        private CheatActivatedUI cheatActivatedUI;
        private CheatMenuUI cheatMenuUI;
        private long tickCount;

        public CheatLists cheatLists;
        private CheatCodeChecker codeChecker;
        private Cheat activatedCheat;

        private bool isActivatedForOneTick;
        private ScriptSettings settings;
        //private IEnumerable<CheatCodes> enumCheats;

        public SaCheatsScript()
        {
            this.settings = ScriptSettings.Load(@"scripts\CheatsSettings.ini");
            this.isActivatedForOneTick = false;
            this.codeChecker = new CheatCodeChecker(this);
            this.tickCount = 0L;
            cheatActivatedUI = new CheatActivatedUI();
            cheatLists = new CheatLists(this);

            cheatLists.AddCheat(new LetsGoBaseJumping());
            cheatLists.AddCheat(new INeedSomeHelp());
            cheatLists.AddCheat(new NoOneCanHurtMe());
            cheatLists.AddCheat(new ManFromAtlantis());
            cheatLists.AddCheat(new Rocketman());
            cheatLists.AddCheat(new ThugsArmoury());
            cheatLists.AddCheat(new ProfessionalsKit());
            cheatLists.AddCheat(new NuttersToys());
            cheatLists.AddCheat(new StickLikeGlue());
            cheatLists.AddCheat(new TakeAChillPill());
            cheatLists.AddCheat(new FullClip());
            cheatLists.AddCheat(new TurnUpTheHeat());
            cheatLists.AddCheat(new TurnDownTheHeat());
            cheatLists.AddCheat(new WhoAteAllThePies());
            cheatLists.AddCheat(new BuffMeUp());
            cheatLists.AddCheat(new LeanAndMean());
            cheatLists.AddCheat(new IDoAsIPlease());
            cheatLists.AddCheat(new BringItOn());
            cheatLists.AddCheat(new Worshipme());
            cheatLists.AddCheat(new HelloLadies());
            cheatLists.AddCheat(new ICanGoAllNight());
            cheatLists.AddCheat(new ProfessionalKiller());
            cheatLists.AddCheat(new NaturalTalent());
            cheatLists.AddCheat(new SpeedItUp());
            cheatLists.AddCheat(new SlowItDown());
            cheatLists.AddCheat(new RoughNeighbourhood());
            cheatLists.AddCheat(new StopPickingOnMe());
            cheatLists.AddCheat(new SurroundedByNutters());
            cheatLists.AddCheat(new GoodbyeCruelWorld());
            cheatLists.AddCheat(new BlueSuedeShoes());
            cheatLists.AddCheat(new AttackOfTheVillagePeople());
            cheatLists.AddCheat(new LifesABeach());
            cheatLists.AddCheat(new OnlyHomiesAllowed());
            cheatLists.AddCheat(new BetterStayIndoors());
            cheatLists.AddCheat(new NinjaTown());
            cheatLists.AddCheat(new LoveConquersAll());
            cheatLists.AddCheat(new CJPhoneHome((Script)this));
            cheatLists.AddCheat(new Kangaroo());
            cheatLists.AddCheat(new StateOfEmergency());
            cheatLists.AddCheat(new Crazytown());
            cheatLists.AddCheat(new WannaBeInMyGang());
            cheatLists.AddCheat(new RocketMayhem());
            cheatLists.AddCheat(new AllCarsGoBoom());
            cheatLists.AddCheat(new WheelsOnlyPlease());
            cheatLists.AddCheat(new DontTryAndStopMe());
            cheatLists.AddCheat(new AllDriversAreCriminals());
            cheatLists.AddCheat(new PinkIsTheNewCool());
            cheatLists.AddCheat(new SoLongAsItsBlack());
            cheatLists.AddCheat(new EveryoneIsPoor());
            cheatLists.AddCheat(new EveryoneIsRich());
            cheatLists.AddCheat(new ChittyChittyBangBang());
            cheatLists.AddCheat(new FlyingFish());
            cheatLists.AddCheat(new TouchMyCarYouDie());
            cheatLists.AddCheat(new SpeedFreak());
            cheatLists.AddCheat(new BubbleCars());
            cheatLists.AddCheat(new IWannaDriveBy());
            cheatLists.AddCheat(new GhostTown());
            cheatLists.AddCheat(new HicksVille());
            cheatLists.AddCheat(new NoOneCanStopUs());
            cheatLists.AddCheat(new TimeToKickAss());
            cheatLists.AddCheat(new OldSpeedDemon());
            cheatLists.AddCheat(new DoughnutHandicap());
            cheatLists.AddCheat(new NotForPublicRoads());
            cheatLists.AddCheat(new JustTryAndStopMe());
            cheatLists.AddCheat(new WheresTheFuneral());
            cheatLists.AddCheat(new CelebrityStatus());
            cheatLists.AddCheat(new TrueGrime());
            cheatLists.AddCheat(new _18Holes());
            cheatLists.AddCheat(new JumpJet());
            cheatLists.AddCheat(new IWantToHover());
            cheatLists.AddCheat(new OhDude());
            cheatLists.AddCheat(new FourWheelFun());
            cheatLists.AddCheat(new HitTheRoadJack());
            cheatLists.AddCheat(new ItsAllBull());
            cheatLists.AddCheat(new FlyingToStunt());
            cheatLists.AddCheat(new MonsterMash());
            cheatLists.AddCheat(new PleasantlyWarm());
            cheatLists.AddCheat(new TooDamnHot());
            cheatLists.AddCheat(new DullDullDay());
            cheatLists.AddCheat(new StayInAndWatchTV());
            cheatLists.AddCheat(new CantSeeWhereImGoing());
            cheatLists.AddCheat(new TimeJustFliesBy());
            cheatLists.AddCheat(new NightProwler());
            cheatLists.AddCheat(new DontBringOnTheNight());
            cheatLists.AddCheat(new ScottishSummer());
            cheatLists.AddCheat(new SandInMyEars());
            cheatLists.AddCheat(new SmallStepForMan());
            cheatLists.AddCheat(new StingLikeABee());

            cheatMenuUI = new CheatMenuUI(cheatLists);
            modSoundPlayer = new ModSoundPlayer();

            //this.enumCheats = Enum.GetValues(typeof(CheatCodes)).Cast<CheatCodes>();
            this.KeyDown += new KeyEventHandler(this.OnKeyDown);
            this.KeyUp += new KeyEventHandler(this.OnKeyUp);
            this.Tick += new EventHandler(this.TickFunc);
        }

        public void OnKeyDown(object o, KeyEventArgs e)
        {
            if(e.KeyCode == settings.GetValue<Keys>("Controls", "MenuEnable", Keys.F6))
            {
                cheatMenuUI.Enabled = !cheatMenuUI.Enabled;
            }
            else if(e.KeyCode == settings.GetValue<Keys>("Controls", "MenuUp", Keys.NumPad8))
            {
                cheatMenuUI.MoveUp();
            }
            else if(e.KeyCode == settings.GetValue<Keys>("Controls", "MenuDown", Keys.NumPad2))
            {
                cheatMenuUI.MoveDown();
            }
            else if(e.KeyCode == settings.GetValue<Keys>("Controls", "MenuConfirm", Keys.NumPad5))
            {
                cheatMenuUI.Click();
            }
            else if(e.KeyCode == settings.GetValue<Keys>("Controls", "MenuBack", Keys.NumPad0))
            {
                cheatMenuUI.Back();
            }
        }
        public void OnKeyUp(object o, KeyEventArgs e)
        {

            AddInput(e);

            //int index = codeChecker.CheakForCheatCode();
            activatedCheat = codeChecker.CheckForCheatCode();
            
            if (activatedCheat != null)
            {
                ActivateCheat(activatedCheat);
                cheatActivatedUI.UpdateUI(activatedCheat);
            }
        }

        public void AddCheat(Cheat cheat) => this.Tick += new EventHandler(cheat.CheatActive);

        public void RemoveCheat(Cheat cheat) => this.Tick -= new EventHandler(cheat.CheatActive);

        public void ActivateForOneTick() => this.isActivatedForOneTick = true;

        public long CurrentTick() => this.tickCount;

        public void TickFunc(object o, EventArgs e)
        {
            ++this.tickCount;
            if (this.isActivatedForOneTick)
            {
                this.RemoveCheat(this.activatedCheat);
                this.isActivatedForOneTick = false;
            }
            cheatActivatedUI.DrawUI();
            cheatMenuUI.Draw();
        }

        public void PlaySound()
        {
            try
            {
                modSoundPlayer.PlaySound();
            } catch(Exception ex)
            {
                GTA.UI.Screen.ShowSubtitle("Did you put the sound file in the right folder?", 5000);
            }
        }

        public void ActivateCheat(Cheat activatedCheat)
        {
            this.activatedCheat = activatedCheat;
            if (this.activatedCheat.type == CheatType.Active)
            {
                if (this.activatedCheat.Toggled)
                {
                    this.activatedCheat.Toggle();
                    this.RemoveCheat(this.activatedCheat);
                }
                else
                {
                    this.activatedCheat.Toggle();
                    this.AddCheat(this.activatedCheat);
                }
            }
            else if (this.activatedCheat.type == CheatType.Instant)
            {
                this.ActivateForOneTick();
                this.AddCheat(this.activatedCheat);
            }
            
            PlaySound();
        }

        public void AddInput(KeyEventArgs e)
        {
            string input = e.KeyCode.ToString();

            if (input.Length == 2 && input.StartsWith("D"))
                input = input[1].ToString();

            //GTA.UI.Screen.ShowSubtitle(input, 1500);
            if (input.Length != 1)
                return;
            this.codeChecker.AddInput(input);
        }

        public void showMsg(string text, int ms)
        {
            GTA.UI.Screen.ShowSubtitle(text, ms);
        }
    }
}
