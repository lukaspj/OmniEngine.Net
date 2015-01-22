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
   public class TSDynamicInstance : SceneObjectInstance
   {
      public TSDynamicInstance(string _name = "", string _className = "TSDynamic", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool allowPlayerStep
      {
         set { Fields["allowPlayerStep"] = value.ToString(); }
      }

      public TypeTSMeshType collisionType
      {
         set { Fields["collisionType"] = value.ToString(); }
      }

      public TypeTSMeshType decalType
      {
         set { Fields["decalType"] = value.ToString(); }
      }

      public int forceDetail
      {
         set { Fields["forceDetail"] = value.ToString(); }
      }

      public bool meshCulling
      {
         set { Fields["meshCulling"] = value.ToString(); }
      }

      public bool originSort
      {
         set { Fields["originSort"] = value.ToString(); }
      }

      public bool playAmbient
      {
         set { Fields["playAmbient"] = value.ToString(); }
      }

      public float renderNormals
      {
         set { Fields["renderNormals"] = value.ToString(); }
      }

      public TypeShapeFilename shapeName
      {
         set { Fields["shapeName"] = value.ToString(); }
      }

      public String skin
      {
         set { Fields["skin"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator TSDynamic(TSDynamicInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         TSDynamic ret = new TSDynamic();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(TSDynamicInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
