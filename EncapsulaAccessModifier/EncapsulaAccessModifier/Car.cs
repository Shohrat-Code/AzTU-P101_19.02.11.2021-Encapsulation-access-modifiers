using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulaAccessModifier
{
    class Car
    {
        public readonly int count;
        private string _brand;
        private string _model;
        private string _color;
        private short _speed;
        private byte _doorCount;

        public Car(string Brand, string Model, string Color, short Speed, byte DoorCount)
        {
            this._brand = Brand;
            this._model = Model;
            this._color = Color;
            this._speed = Speed;
            this._doorCount = DoorCount;
        }

        public string Brand { get { return this._brand; } }
        public string Model { get { return this._model; } }
        public string Color { get { return this._color; } }
        public short Speed { get { return this._speed; } }
        public byte DoorCount { get { return this._doorCount; } }
    }
}
