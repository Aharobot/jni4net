//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.runtime.rule {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface WorkingMemoryEntryPoint {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/drools/runtime/rule/FactHandle;)Ljava/lang/Object;")]
        global::java.lang.Object getObject(global::org.drools.runtime.rule.FactHandle par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Lorg/drools/runtime/rule/FactHandle;")]
        global::org.drools.runtime.rule.FactHandle insert(global::java.lang.Object par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/drools/runtime/rule/FactHandle;Ljava/lang/Object;)V")]
        void update(global::org.drools.runtime.rule.FactHandle par0, global::java.lang.Object par1);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Lorg/drools/runtime/rule/FactHandle;")]
        global::org.drools.runtime.rule.FactHandle getFactHandle(global::java.lang.Object par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        global::java.lang.String getEntryPointId();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/drools/runtime/rule/FactHandle;)V")]
        void retract(global::org.drools.runtime.rule.FactHandle par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/drools/runtime/ObjectFilter;)Ljava/util/Collection;")]
        global::java.util.Collection getObjects(global::org.drools.runtime.ObjectFilter par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Collection;")]
        global::java.util.Collection getObjects();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/drools/runtime/ObjectFilter;)Ljava/util/Collection;")]
        global::java.util.Collection getFactHandles(global::org.drools.runtime.ObjectFilter par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Collection;")]
        global::java.util.Collection getFactHandles();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()J")]
        long getFactCount();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class WorkingMemoryEntryPoint_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.runtime.rule.WorkingMemoryEntryPoint), typeof(global::org.drools.runtime.rule.WorkingMemoryEntryPoint_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.runtime.rule.WorkingMemoryEntryPoint), typeof(global::org.drools.runtime.rule.WorkingMemoryEntryPoint_))]
    internal sealed partial class @__WorkingMemoryEntryPoint : global::java.lang.Object, global::org.drools.runtime.rule.WorkingMemoryEntryPoint {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getObject0;
        
        internal static global::net.sf.jni4net.jni.MethodId _insert1;
        
        internal static global::net.sf.jni4net.jni.MethodId _update2;
        
        internal static global::net.sf.jni4net.jni.MethodId _getFactHandle3;
        
        internal static global::net.sf.jni4net.jni.MethodId _getEntryPointId4;
        
        internal static global::net.sf.jni4net.jni.MethodId _retract5;
        
        internal static global::net.sf.jni4net.jni.MethodId _getObjects6;
        
        internal static global::net.sf.jni4net.jni.MethodId _getObjects7;
        
        internal static global::net.sf.jni4net.jni.MethodId _getFactHandles8;
        
        internal static global::net.sf.jni4net.jni.MethodId _getFactHandles9;
        
        internal static global::net.sf.jni4net.jni.MethodId _getFactCount10;
        
        private @__WorkingMemoryEntryPoint(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint.staticClass = @__class;
            global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint._getObject0 = @__env.GetMethodID(global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint.staticClass, "getObject", "(Lorg/drools/runtime/rule/FactHandle;)Ljava/lang/Object;");
            global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint._insert1 = @__env.GetMethodID(global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint.staticClass, "insert", "(Ljava/lang/Object;)Lorg/drools/runtime/rule/FactHandle;");
            global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint._update2 = @__env.GetMethodID(global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint.staticClass, "update", "(Lorg/drools/runtime/rule/FactHandle;Ljava/lang/Object;)V");
            global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint._getFactHandle3 = @__env.GetMethodID(global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint.staticClass, "getFactHandle", "(Ljava/lang/Object;)Lorg/drools/runtime/rule/FactHandle;");
            global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint._getEntryPointId4 = @__env.GetMethodID(global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint.staticClass, "getEntryPointId", "()Ljava/lang/String;");
            global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint._retract5 = @__env.GetMethodID(global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint.staticClass, "retract", "(Lorg/drools/runtime/rule/FactHandle;)V");
            global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint._getObjects6 = @__env.GetMethodID(global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint.staticClass, "getObjects", "(Lorg/drools/runtime/ObjectFilter;)Ljava/util/Collection;");
            global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint._getObjects7 = @__env.GetMethodID(global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint.staticClass, "getObjects", "()Ljava/util/Collection;");
            global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint._getFactHandles8 = @__env.GetMethodID(global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint.staticClass, "getFactHandles", "(Lorg/drools/runtime/ObjectFilter;)Ljava/util/Collection;");
            global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint._getFactHandles9 = @__env.GetMethodID(global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint.staticClass, "getFactHandles", "()Ljava/util/Collection;");
            global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint._getFactCount10 = @__env.GetMethodID(global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint.staticClass, "getFactCount", "()J");
        }
        
        public global::java.lang.Object getObject(global::org.drools.runtime.rule.FactHandle par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint._getObject0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.runtime.rule.FactHandle>(@__env, par0)));
            }
        }
        
        public global::org.drools.runtime.rule.FactHandle insert(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.FactHandle>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint._insert1, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0)));
            }
        }
        
        public void update(global::org.drools.runtime.rule.FactHandle par0, global::java.lang.Object par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallVoidMethod(this, global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint._update2, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.runtime.rule.FactHandle>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par1));
            }
        }
        
        public global::org.drools.runtime.rule.FactHandle getFactHandle(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.FactHandle>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint._getFactHandle3, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0)));
            }
        }
        
        public global::java.lang.String getEntryPointId() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint._getEntryPointId4));
            }
        }
        
        public void retract(global::org.drools.runtime.rule.FactHandle par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint._retract5, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.runtime.rule.FactHandle>(@__env, par0));
            }
        }
        
        public global::java.util.Collection getObjects(global::org.drools.runtime.ObjectFilter par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint._getObjects6, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.runtime.ObjectFilter>(@__env, par0)));
            }
        }
        
        public global::java.util.Collection getObjects() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint._getObjects7));
            }
        }
        
        public global::java.util.Collection getFactHandles(global::org.drools.runtime.ObjectFilter par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint._getFactHandles8, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.runtime.ObjectFilter>(@__env, par0)));
            }
        }
        
        public global::java.util.Collection getFactHandles() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint._getFactHandles9));
            }
        }
        
        public long getFactCount() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((long)(@__env.CallLongMethod(this, global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint._getFactCount10)));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__WorkingMemoryEntryPoint);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getObject", "getObject0", "(Lorg/drools/runtime/rule/FactHandle;)Ljava/lang/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "insert", "insert1", "(Ljava/lang/Object;)Lorg/drools/runtime/rule/FactHandle;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "update", "update2", "(Lorg/drools/runtime/rule/FactHandle;Ljava/lang/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getFactHandle", "getFactHandle3", "(Ljava/lang/Object;)Lorg/drools/runtime/rule/FactHandle;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getEntryPointId", "getEntryPointId4", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "retract", "retract5", "(Lorg/drools/runtime/rule/FactHandle;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getObjects", "getObjects6", "(Lorg/drools/runtime/ObjectFilter;)Ljava/util/Collection;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getObjects", "getObjects7", "()Ljava/util/Collection;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getFactHandles", "getFactHandles8", "(Lorg/drools/runtime/ObjectFilter;)Ljava/util/Collection;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getFactHandles", "getFactHandles9", "()Ljava/util/Collection;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getFactCount", "getFactCount10", "()J"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getObject0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lorg/drools/runtime/rule/FactHandle;)Ljava/lang/Object;
            // (Lorg/drools/runtime/rule/FactHandle;)Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.runtime.rule.WorkingMemoryEntryPoint @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.WorkingMemoryEntryPoint>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.lang.Object>(@__env, @__real.getObject(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.FactHandle>(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle insert1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/Object;)Lorg/drools/runtime/rule/FactHandle;
            // (Ljava/lang/Object;)Lorg/drools/runtime/rule/FactHandle;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.runtime.rule.WorkingMemoryEntryPoint @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.WorkingMemoryEntryPoint>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.runtime.rule.FactHandle>(@__env, @__real.insert(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void update2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0, global::net.sf.jni4net.utils.JniLocalHandle par1) {
            // (Lorg/drools/runtime/rule/FactHandle;Ljava/lang/Object;)V
            // (Lorg/drools/runtime/rule/FactHandle;Ljava/lang/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.runtime.rule.WorkingMemoryEntryPoint @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.WorkingMemoryEntryPoint>(@__env, @__obj);
            @__real.update(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.FactHandle>(@__env, par0), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, par1));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getFactHandle3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/Object;)Lorg/drools/runtime/rule/FactHandle;
            // (Ljava/lang/Object;)Lorg/drools/runtime/rule/FactHandle;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.runtime.rule.WorkingMemoryEntryPoint @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.WorkingMemoryEntryPoint>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.runtime.rule.FactHandle>(@__env, @__real.getFactHandle(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getEntryPointId4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.runtime.rule.WorkingMemoryEntryPoint @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.WorkingMemoryEntryPoint>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.getEntryPointId());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void retract5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lorg/drools/runtime/rule/FactHandle;)V
            // (Lorg/drools/runtime/rule/FactHandle;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.runtime.rule.WorkingMemoryEntryPoint @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.WorkingMemoryEntryPoint>(@__env, @__obj);
            @__real.retract(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.FactHandle>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getObjects6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lorg/drools/runtime/ObjectFilter;)Ljava/util/Collection;
            // (Lorg/drools/runtime/ObjectFilter;)Ljava/util/Collection;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.runtime.rule.WorkingMemoryEntryPoint @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.WorkingMemoryEntryPoint>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.Collection>(@__env, @__real.getObjects(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.ObjectFilter>(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getObjects7(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/util/Collection;
            // ()Ljava/util/Collection;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.runtime.rule.WorkingMemoryEntryPoint @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.WorkingMemoryEntryPoint>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.Collection>(@__env, @__real.getObjects());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getFactHandles8(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lorg/drools/runtime/ObjectFilter;)Ljava/util/Collection;
            // (Lorg/drools/runtime/ObjectFilter;)Ljava/util/Collection;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.runtime.rule.WorkingMemoryEntryPoint @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.WorkingMemoryEntryPoint>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.Collection>(@__env, @__real.getFactHandles(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.ObjectFilter>(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getFactHandles9(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/util/Collection;
            // ()Ljava/util/Collection;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.runtime.rule.WorkingMemoryEntryPoint @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.WorkingMemoryEntryPoint>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.Collection>(@__env, @__real.getFactHandles());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static long getFactCount10(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()J
            // ()J
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            long @__return = default(long);
            try {
            global::org.drools.runtime.rule.WorkingMemoryEntryPoint @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.WorkingMemoryEntryPoint>(@__env, @__obj);
            @__return = ((long)(@__real.getFactCount()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.runtime.rule.@__WorkingMemoryEntryPoint(@__env);
            }
        }
    }
    #endregion
}
