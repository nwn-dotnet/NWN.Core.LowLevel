//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NWN.Native.API {

public unsafe class CassowarySolverEngineStructure : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CassowarySolverEngineStructure(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CassowarySolverEngineStructure(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CassowarySolverEngineStructure obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CassowarySolverEngineStructure() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CassowarySolverEngineStructure(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CassowarySolverEngineStructure self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CassowarySolverEngineStructure self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CassowarySolverEngineStructure other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CassowarySolverEngineStructure other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CassowarySolverEngineStructure left, CassowarySolverEngineStructure right) {
    return Equals(left, right);
  }

  public static bool operator !=(CassowarySolverEngineStructure left, CassowarySolverEngineStructure right) {
    return !Equals(left, right);
  }

  public SWIGTYPE_p_std__shared_ptrT_void_p_t m_shared {
    set {
      NWNXLibPINVOKE.CassowarySolverEngineStructure_m_shared_set(swigCPtr, SWIGTYPE_p_std__shared_ptrT_void_p_t.getCPtr(value));
      if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_std__shared_ptrT_void_p_t ret = new SWIGTYPE_p_std__shared_ptrT_void_p_t(NWNXLibPINVOKE.CassowarySolverEngineStructure_m_shared_get(swigCPtr), true);
      if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public CassowarySolverEngineStructure() : this(NWNXLibPINVOKE.new_CassowarySolverEngineStructure(), true) {
  }

}

}
