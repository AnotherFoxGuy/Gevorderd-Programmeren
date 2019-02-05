using System;
using NUnit.Framework;

namespace HeldenEnSchurken
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void NewPersons()
        {
            var v = new Villain("fsgfdh",500);
            var h = new Hero("Kaas", v);
            Assert.AreEqual("Kaas",h.GetName());
            Assert.AreEqual(v,h.GetArchnemesis());
        }

        [Test]
        public void Strengths()
        {
            var v = new Villain("fsgfdh",500);
            var h = new Hero("Kaas", v);
            
            
            v.AddStrengths("gbhfgh");
            v.AddStrengths("tbyjbfj");
            
            h.AddStrengths("Boter");
            h.AddStrengths("Majo");
            
            Assert.AreEqual("gbhfgh",v.GetStrengths()[0]);
            Assert.AreEqual("tbyjbfj",v.GetStrengths()[1]);
            
            Assert.AreEqual("Boter",h.GetStrengths()[0]);
            Assert.AreEqual("Majo",h.GetStrengths()[1]);
        }

        [Test]
        public void Sidekick()
        {
            var v = new Villain("Moo",500);
            var h = new Hero("Kaas", v);
            var s = new Villain("Boter",30);
            
            h.UpdateSidekick(s);
            Assert.AreEqual(s, h.GetSidekick());
            
            var st = new Hero("vbfhbf", v);;
            
            h.UpdateSidekick(st);
            Assert.AreEqual(st, h.GetSidekick());
        }

        [Test]
        public void Minions()
        {
            var v = new Villain("Moo",500);
            
            v.AddMinion( new Minion("HHhhdsf"));
            v.AddMinion(new Minion("vgfhbfg"));
           
            Assert.AreEqual("HHhhdsf",v.GetMinions()[0].GetWeakness());
            Assert.AreEqual("vgfhbfg",v.GetMinions()[1].GetWeakness());
        }

        [Test]
        public void Evilness()
        {
            var v1 =  new Villain("Moo",73);
            var v2 =  new Villain("Moo",500);
            Assert.AreEqual(v1.getEvilness(),73);
            Assert.AreEqual(v2.getEvilness(),50);
        }
    }
}