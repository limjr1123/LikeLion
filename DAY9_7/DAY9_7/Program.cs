﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY9_7
{

    //부모클래스(기본 유닛)
    class Unit
    {
        public string Name;
        protected int Health;
        public Unit()
        {
            Name = "Unknown";
            Health = 0;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name}이 기본 공격을 합니다.");
        }

        public virtual void Heal(Unit target)
        {
            Console.WriteLine($"{Name}은 치료할 수 없습니다.");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name}이 이동합니다.");
        }
    }
    class SCV : Unit
    {
        public SCV()
        {
            Name = "SCV";
            Health = 60;
        }

        public override void Attack()
        {
            Console.WriteLine("SCV가 용접기로 공격합니다.! (공격력이 약함)");
        }

        public override void Heal(Unit target)
        {
            Console.WriteLine($"SCV가 {target.Name}을 수리합니다.(기계 유닛만 가능)");
        }
    }

    //Marine 유닛
    class Marine : Unit
    {
        public Marine()
        {
            Name = "marine";
            Health = 40;
        }

        public override void Attack()
        {
            Console.WriteLine("Marine이 소총으로 공격합니다.");
        }

    }

    class Medic : Unit
    {
        public Medic()
        {
            Name = "medic";
            Health = 60;
        }

        public override void Heal(Unit target)
        {

            Console.WriteLine($"Medic이 {target.Name}을 치료합니다.(생명유닛만 가능)");
        }

    }

    class Tank : Unit
    {
        public Tank()
        {
            Name = "tank";
            Health = 150;
        }

        public override void Attack()
        {
            Console.WriteLine($"tank가 시즈모드로 강력한포격 .");
        }

        public override void Move()
        {
            Console.WriteLine("탱크가 천천히 움직입니다.");
        }
    }

    //SCV 유닛 (건설과 수리기능)


    class Program
    {
        static void Main(string[] args)
        {
            List<Unit> units = new List<Unit>();


            units.Add(new SCV());
            units.Add(new Marine());
            units.Add(new Medic());
            units.Add(new Tank());


            //모든 유닛을 순회하며 다형성 적용
            foreach (var unit in units)
            {
                unit.Move(); //이동
                unit.Attack(); //공격
                Console.WriteLine();
            }


            //SCV가 탱크 수리 시도
            SCV scv = new SCV();
            scv.Heal(units[3]); //탱크 수리

            //Medic이 Marince 치료시도
            Medic medic = new Medic();

            medic.Heal(units[1]); //Marine을 치료
        }
    }
}
