using System;
using System.Collections.Generic;
using System.Linq;

using Docky.Items;
using Docky.Services;

namespace HelloWorld {
    public class HelloWorldItemProvider : AbstractDockItemProvider {
        #region IDockItemProvider implementation

        public override string Name {
            get {
                return "HelloWorld";
            }
        }

        public override bool AutoDisable {
            get {
                return false;
            }
        }

        #endregion

        public HelloWorldItemProvider() {
            Log.Info("Hello, World!");
        }
    }
}
