using System;

namespace RolePlayV11
{
    public class Warrior
    {
        #region Instance fields
        private string _name;
        private int _level;
        private int _hitPoints;
        #endregion

        #region Constructor
        public Warrior(string name , int hitPoints)
        {
            _name = name;
            _level = 1;
            _hitPoints = hitPoints;
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
        }

        public int Level
        {
            get { return _level; }
        }
        public int HitPoints{
            get {return _hitPoints;}
        }
        public bool Dead{
            get{return 0 >= _hitPoints;}
        }
        #endregion

        #region Methods
        public void LevelUp()
        {
            _level = _level + 1;
        }
        public void TakeDamage(int damage){
            _hitPoints -= damage;
        }
        public int DealDamage(){
            return new Random().Next(10, 31); 
        }
        #endregion
    }
}