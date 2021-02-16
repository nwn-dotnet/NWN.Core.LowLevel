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

public unsafe class CExoArrayListCNWSStatsSpellPtrArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CExoArrayListCNWSStatsSpellPtrArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CExoArrayListCNWSStatsSpellPtrArray(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCNWSStatsSpellPtrArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCNWSStatsSpellPtrArray() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCNWSStatsSpellPtrArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public CExoArrayListCNWSStatsSpellPtr this[int index] {
    get {
      return GetItem(index);
    }
    set {
      SetItem(index, value);
    }
  }

  public System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static implicit operator void*(CExoArrayListCNWSStatsSpellPtrArray self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CExoArrayListCNWSStatsSpellPtrArray self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CExoArrayListCNWSStatsSpellPtrArray other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCNWSStatsSpellPtrArray other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCNWSStatsSpellPtrArray left, CExoArrayListCNWSStatsSpellPtrArray right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCNWSStatsSpellPtrArray left, CExoArrayListCNWSStatsSpellPtrArray right) {
    return !Equals(left, right);
  }

  public CExoArrayListCNWSStatsSpellPtrArray(int nElements) : this(NWNXLibPINVOKE.new_CExoArrayListCNWSStatsSpellPtrArray(nElements), true) {
  }

  public CExoArrayListCNWSStatsSpellPtr GetItem(int index) {
    CExoArrayListCNWSStatsSpellPtr ret = new CExoArrayListCNWSStatsSpellPtr(NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellPtrArray_GetItem(swigCPtr, index), true);
    return ret;
  }

  public void SetItem(int index, CExoArrayListCNWSStatsSpellPtr value) {
    NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellPtrArray_SetItem(swigCPtr, index, CExoArrayListCNWSStatsSpellPtr.getCPtr(value));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public static CExoArrayListCNWSStatsSpellPtrArray FromPointer(CExoArrayListCNWSStatsSpellPtr ptr) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWSStatsSpellPtrArray_FromPointer(CExoArrayListCNWSStatsSpellPtr.getCPtr(ptr));
    CExoArrayListCNWSStatsSpellPtrArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCNWSStatsSpellPtrArray(cPtr, false);
    return ret;
  }

}

}