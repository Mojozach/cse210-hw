using System;
using System.Collections.Generic;

namespace RPGGame
{
    public class Character
    {
        protected string _name;
        protected int _health;
        protected int _strength;
        protected int _agility;
        protected int _intelligence;

        public virtual void Move(string direction) { }
        public virtual void Attack(Character target) { }
        public virtual void UseItem(Gear item) { }
        public virtual void InteractWith(ObjectInteraction obj) { }
    }

    public class Human : Character
    {
        private int _morale;
    }

    public class Elf : Character
    {
        private int _dexterity;
    }

    public class Wizard : Character
    {
        private int _mana;

        public void CastSpell(string spellName, Character target) { }
    }

    public class Room
    {
        private string _name;
        private string _description;
        private List<Room> _connectedRooms = new List<Room>();
        private List<ObjectInteraction> _objects = new List<ObjectInteraction>();

        public void Enter(Character character) { }
        public Room Exit(string direction) { return null; }
        public string Describe() { return _description; }
    }

    public class Weapons
    {
        private string _name;
        private int _damage;
        private int _range;

        public void Equip() { }
        public void Use(Character target) { }
    }

    public class Gear
    {
        private string _name;
        private int _defense;
        private float _weight;

        public void Equip() { }
        public void Unequip() { }
    }

    public class Combat
    {
        private List<Character> _participants = new List<Character>();
        private List<Character> _turnOrder = new List<Character>();

        public void Start() { }
        public void TakeTurn(Character character) { }
        public void Resolve() { }
    }

    public class ObjectInteraction
    {
        private string _objectName;
        private bool _isInteractive;

        public void Interact(Character character) { }
    }

    public class Traps
    {
        private string _trapType;
        private int _damage;
        private bool _isHidden;

        public void Trigger(Character character) { }
        public bool Disarm() { return false; }
    }

    public class UserInterface
    {
        public void DisplayCharacterStats(Character character) { }
        public void RenderRoom(Room room) { }
        public void ShowCombatOptions(Character character) { }
        public void PromptInteraction(ObjectInteraction obj) { }
    }
}
