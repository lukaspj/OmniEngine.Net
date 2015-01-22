using System;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;

namespace WinterLeaf.Demo.Full.Models.Base.Creators
{
   /// <summary>
   /// 
   /// </summary>
   public class AIPlayerInstance : PlayerInstance
   {
      public AIPlayerInstance(string _name = "", string _className = "AIPlayer", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool allowClimb
      {
         set { Fields["allowClimb"] = value.ToString(); }
      }

      public bool allowDrop
      {
         set { Fields["allowDrop"] = value.ToString(); }
      }

      public bool allowJump
      {
         set { Fields["allowJump"] = value.ToString(); }
      }

      public bool allowLedge
      {
         set { Fields["allowLedge"] = value.ToString(); }
      }

      public bool allowSwim
      {
         set { Fields["allowSwim"] = value.ToString(); }
      }

      public bool allowTeleport
      {
         set { Fields["allowTeleport"] = value.ToString(); }
      }

      public bool allowWalk
      {
         set { Fields["allowWalk"] = value.ToString(); }
      }

      public float mMoveTolerance
      {
         set { Fields["mMoveTolerance"] = value.ToString(); }
      }

      public int moveStuckTestDelay
      {
         set { Fields["moveStuckTestDelay"] = value.ToString(); }
      }

      public float moveStuckTolerance
      {
         set { Fields["moveStuckTolerance"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator AIPlayer(AIPlayerInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         AIPlayer ret = new AIPlayer();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(AIPlayerInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
