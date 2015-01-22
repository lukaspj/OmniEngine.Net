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
   public class TerrainBlockInstance : SceneObjectInstance
   {
      public TerrainBlockInstance(string _name = "", string _className = "TerrainBlock", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public int baseTexSize
      {
         set { Fields["baseTexSize"] = value.ToString(); }
      }

      public bool castShadows
      {
         set { Fields["castShadows"] = value.ToString(); }
      }

      public int lightMapSize
      {
         set { Fields["lightMapSize"] = value.ToString(); }
      }

      public int screenError
      {
         set { Fields["screenError"] = value.ToString(); }
      }

      public float squareSize
      {
         set { Fields["squareSize"] = value.ToString(); }
      }

      public String terrainFile
      {
         set { Fields["terrainFile"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator TerrainBlock(TerrainBlockInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         TerrainBlock ret = new TerrainBlock();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(TerrainBlockInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
