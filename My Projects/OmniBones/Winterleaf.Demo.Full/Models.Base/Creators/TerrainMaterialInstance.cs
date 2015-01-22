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
   public class TerrainMaterialInstance : SimObjectInstance
   {
      public TerrainMaterialInstance(string _name = "", string _className = "TerrainMaterial", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float detailDistance
      {
         set { Fields["detailDistance"] = value.ToString(); }
      }

      public String detailMap
      {
         set { Fields["detailMap"] = value.ToString(); }
      }

      public float detailSize
      {
         set { Fields["detailSize"] = value.ToString(); }
      }

      public float detailStrength
      {
         set { Fields["detailStrength"] = value.ToString(); }
      }

      public String diffuseMap
      {
         set { Fields["diffuseMap"] = value.ToString(); }
      }

      public float diffuseSize
      {
         set { Fields["diffuseSize"] = value.ToString(); }
      }

      public float macroDistance
      {
         set { Fields["macroDistance"] = value.ToString(); }
      }

      public String macroMap
      {
         set { Fields["macroMap"] = value.ToString(); }
      }

      public float macroSize
      {
         set { Fields["macroSize"] = value.ToString(); }
      }

      public float macroStrength
      {
         set { Fields["macroStrength"] = value.ToString(); }
      }

      public String normalMap
      {
         set { Fields["normalMap"] = value.ToString(); }
      }

      public float parallaxScale
      {
         set { Fields["parallaxScale"] = value.ToString(); }
      }

      public bool useSideProjection
      {
         set { Fields["useSideProjection"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator TerrainMaterial(TerrainMaterialInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         TerrainMaterial ret = new TerrainMaterial();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(TerrainMaterialInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
