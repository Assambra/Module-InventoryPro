using System;
using System.Collections.Generic;

namespace Assambra.General.ThirdParty.FullSerializer {
    partial class fsConverterRegistrar {
        public static Speedup.Devdog_General_MotionInfo_DirectConverter Register_Devdog_General_MotionInfo;
    }
}

namespace Assambra.General.ThirdParty.FullSerializer.Speedup {
    public class Devdog_General_MotionInfo_DirectConverter : fsDirectConverter<Assambra.General.MotionInfo> {
        protected override fsResult DoSerialize(Assambra.General.MotionInfo model, Dictionary<string, fsData> serialized) {
            var result = fsResult.Success;

            result += SerializeMember(serialized, null, "motion", model.motion);
            result += SerializeMember(serialized, null, "speed", model.speed);

            return result;
        }

        protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Assambra.General.MotionInfo model) {
            var result = fsResult.Success;

            var t0 = model.motion;
            result += DeserializeMember(data, null, "motion", out t0);
            model.motion = t0;

            var t1 = model.speed;
            result += DeserializeMember(data, null, "speed", out t1);
            model.speed = t1;

            return result;
        }

        public override object CreateInstance(fsData data, Type storageType) {
            return new Assambra.General.MotionInfo();
        }
    }
}
