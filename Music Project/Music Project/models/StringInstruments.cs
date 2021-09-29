using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicObjects.models
{
    public abstract class StringInstrument : Instrument
    {
        public int numberOfStrings { get; set; }

        public StringInstrument()
        {
            numberOfStrings = 6;
        }
    }

    public class Guitar : StringInstrument
    {

        public override string Name
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }
        public override string Play()
        {
            return $"I am playing a Guitar with {numberOfStrings} strings";
        }
    }



    public class Cello : StringInstrument
    {

        public override string Name
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }

        public override string Play()
        {
            return $"I am playing a Cello with {numberOfStrings} strings";
        }

    }


    public class Harp : StringInstrument
    {

        public override string Name
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }
        public override string Play()
        {
            return $"I am playing a Harp with {numberOfStrings} strings";
        }
    }
}