using GTA;
using GTA.Math;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SaCheats
{
    internal class BubbleCars : Cheat
    {
        private long frame;
        private long nextFrame;
        private static float FORCE;
        private bool characterChange;
        private LinkedList<BubbleCars.VehicleAndMass> listOfHitVehicles;
        private Vehicle currentVehicle;
        private Ped player;
        private ScriptSettings settings;

        public BubbleCars()
          : base(CheatType.Active, "BubbleCars", "Vehicles Float Away When Hit With Player's Vehicle")
        {
            this.currentVehicle = (Vehicle)null;
            this.characterChange = true;
            this.settings = ScriptSettings.Load(@"scripts\CheatsSettings.ini");
            FORCE = this.settings.GetValue<float>("BubbleCars", "Force", 1.0f);
            this.listOfHitVehicles = new LinkedList<BubbleCars.VehicleAndMass>();
            foreach (Ped allPed in World.GetAllPeds())
            {
                if (allPed.IsPlayer)
                    this.player = allPed;
            }
            this.frame = Util.nanoTime();
            this.nextFrame = this.frame;
        }

        public void GetCurrentVehicle()
        {
            if (this.player.IsInVehicle())
            {
                this.currentVehicle = Game.Player.Character.CurrentVehicle;
            }
            else
            {
                this.currentVehicle = (Vehicle)null;
            }
        }

        public void HitDetection()
        {
            if (currentVehicle == null)
                return;
            bool flag = false;
            int index = 0;
            foreach (Vehicle nearbyVehicle in World.GetNearbyVehicles(this.player, 20f))
            {
                if (((Entity)this.currentVehicle).IsTouching((Entity)nearbyVehicle))
                {
                    for (; !flag && index < this.listOfHitVehicles.Count; ++index)
                    {
                        if (this.listOfHitVehicles.ElementAt<BubbleCars.VehicleAndMass>(index).Compare(nearbyVehicle))
                            flag = true;
                    }
                    if (!flag)
                        this.listOfHitVehicles.AddLast(new BubbleCars.VehicleAndMass(nearbyVehicle));
                }
                flag = false;
                index = 0;
            }
        }

        public void BubbleCarsLogic()
        {
            foreach (BubbleCars.VehicleAndMass listOfHitVehicle in this.listOfHitVehicles)
                listOfHitVehicle.UseForce();
            List<BubbleCars.VehicleAndMass> list = this.listOfHitVehicles.Where<BubbleCars.VehicleAndMass>((Func<BubbleCars.VehicleAndMass, bool>)(v => v.GetDisplayName() != "CARNOTFOUND")).ToList<BubbleCars.VehicleAndMass>();
            this.listOfHitVehicles.Clear();
            for (int index = 0; index < list.Count; ++index)
                this.listOfHitVehicles.AddLast(list.ElementAt<BubbleCars.VehicleAndMass>(index));
        }

        public void SetPlayer()
        {
            if (!Game.Player.CanControlCharacter)
            {
                this.characterChange = true;
            }
            else
            {
                if (!this.characterChange)
                    return;
                foreach (Ped allPed in World.GetAllPeds())
                {
                    if (allPed.IsPlayer)
                        this.player = allPed;
                }
                this.characterChange = false;
            }
        }

        public override void CheatActive(object o, EventArgs e)
        {
            this.nextFrame = Util.nanoTime();
            this.SetPlayer();
            this.GetCurrentVehicle();
            this.HitDetection();
            if (this.nextFrame - this.frame < 16666666L)
                return;
            this.BubbleCarsLogic();
            this.frame = Util.nanoTime();
        }

        public override void Toggle() => base.Toggle();

        public class VehicleAndMass
        {
            private Vehicle vehicle;
            private Vector3 force;

            public Vector3 Force => this.force;

            public Vehicle Vehicle => this.Vehicle;

            public VehicleAndMass(Vehicle veh)
            {
                this.vehicle = veh;
                this.force = new Vector3(0.0f, 0.0f, BubbleCars.FORCE);
            }

            public void UseForce() => ((Entity)this.vehicle).ApplyForce(this.force);

            public string GetDisplayName()
            {
                if (char.IsNumber(this.vehicle.DisplayName.ElementAt<char>(this.vehicle.DisplayName.Length - 1)))
                    this.vehicle.DisplayName.Remove(this.vehicle.DisplayName.Length - 1);
                return this.vehicle.DisplayName;
            }

            public bool Compare(Vehicle veh) => this.vehicle == veh;
        }
    }
}
