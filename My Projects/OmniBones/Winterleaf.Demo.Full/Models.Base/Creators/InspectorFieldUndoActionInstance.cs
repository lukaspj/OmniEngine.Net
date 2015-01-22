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
   public class InspectorFieldUndoActionInstance : UndoActionInstance
   {
      public InspectorFieldUndoActionInstance(string _name = "", string _className = "InspectorFieldUndoAction", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public String arrayIndex
      {
         set { Fields["arrayIndex"] = value.ToString(); }
      }

      public String fieldName
      {
         set { Fields["fieldName"] = value.ToString(); }
      }

      public String fieldValue
      {
         set { Fields["fieldValue"] = value.ToString(); }
      }

      public GuiInspector inspectorGui
      {
         set { Fields["inspectorGui"] = value.ToString(); }
      }

      public int objectId
      {
         set { Fields["objectId"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator InspectorFieldUndoAction(InspectorFieldUndoActionInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         InspectorFieldUndoAction ret = new InspectorFieldUndoAction();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(InspectorFieldUndoActionInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
