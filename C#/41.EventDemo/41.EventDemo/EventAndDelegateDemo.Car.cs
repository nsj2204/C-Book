﻿using System;

namespace EventAndDelegeteDemo
{
    // 게시자(Publisher)
    class Car
    {
        private int _fuelGuage;
        public int FuelGuage
        {
            get { return _fuelGuage; }
            set 
            { 
                _fuelGuage = value;
                OnFuelEmptyReached();
            }
        }
        public Car()
        {
            _fuelGuage = 25; // 25%
        }
        public void Go()
        {
            Console.WriteLine("운전");
            FuelGuage -= 5; // 5%
        }
        //public delegate void FuelEmptyNotification();
        //public event FuelEmptyNotification FuelEmptyReached;
        public event Action FuelEmptyReached;
        public void OnFuelEmptyReached()
        {
            Console.WriteLine($"연료 상태: {_fuelGuage}%");
            if (_fuelGuage < 20)
            {
                if (FuelEmptyReached != null)
                {
                    FuelEmptyReached?.Invoke();
                } 
            }
        }
    }

}