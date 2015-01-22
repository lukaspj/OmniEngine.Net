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
   public class ForestItemDataInstance : SimDataBlockInstance
   {
      public ForestItemDataInstance(string _name = "", string _className = "ForestItemData", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float branchAmp
      {
         set { Fields["branchAmp"] = value.ToString(); }
      }

      public bool collidable
      {
         set { Fields["collidable"] = value.ToString(); }
      }

      public float dampingCoefficient
      {
         set { Fields["dampingCoefficient"] = value.ToString(); }
      }

      public float detailAmp
      {
         set { Fields["detailAmp"] = value.ToString(); }
      }

      public float detailFreq
      {
         set { Fields["detailFreq"] = value.ToString(); }
      }

      public float mass
      {
         set { Fields["mass"] = value.ToString(); }
      }

      public float radius
      {
         set { Fields["radius"] = value.ToString(); }
      }

      public float rigidity
      {
         set { Fields["rigidity"] = value.ToString(); }
      }

      public TypeShapeFilename shapeFile
      {
         set { Fields["shapeFile"] = value.ToString(); }
      }

      public float tightnessCoefficient
      {
         set { Fields["tightnessCoefficient"] = value.ToString(); }
      }

      public float trunkBendScale
      {
         set { Fields["trunkBendScale"] = value.ToString(); }
      }

      public float windScale
      {
         set { Fields["windScale"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator ForestItemData(ForestItemDataInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         ForestItemData ret = new ForestItemData();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(ForestItemDataInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
