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

public unsafe class CExoArrayListCNWLevelStatsPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CExoArrayListCNWLevelStatsPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CExoArrayListCNWLevelStatsPtr(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCNWLevelStatsPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCNWLevelStatsPtr() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCNWLevelStatsPtr(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListCNWLevelStatsPtr self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CExoArrayListCNWLevelStatsPtr self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CExoArrayListCNWLevelStatsPtr other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCNWLevelStatsPtr other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCNWLevelStatsPtr left, CExoArrayListCNWLevelStatsPtr right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCNWLevelStatsPtr left, CExoArrayListCNWLevelStatsPtr right) {
    return !Equals(left, right);
  }

  public void** element {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWLevelStatsPtr_element_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCNWLevelStatsPtr_element_get(swigCPtr); 
        return (void**)retVal; 
    }

  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWLevelStatsPtr_num_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCNWLevelStatsPtr_num_get(swigCPtr);
      return ret;
    } 
  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWLevelStatsPtr_array_size_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCNWLevelStatsPtr_array_size_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListCNWLevelStatsPtr(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCNWLevelStatsPtr__SWIG_0(s), true) {
  }

  public CExoArrayListCNWLevelStatsPtr() : this(NWNXLibPINVOKE.new_CExoArrayListCNWLevelStatsPtr__SWIG_1(), true) {
  }

  public CExoArrayListCNWLevelStatsPtr(CExoArrayListCNWLevelStatsPtr list) : this(NWNXLibPINVOKE.new_CExoArrayListCNWLevelStatsPtr__SWIG_2(CExoArrayListCNWLevelStatsPtr.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListCNWLevelStatsPtr _OpAssign(CExoArrayListCNWLevelStatsPtr list) {
    CExoArrayListCNWLevelStatsPtr ret = new CExoArrayListCNWLevelStatsPtr(NWNXLibPINVOKE.CExoArrayListCNWLevelStatsPtr__OpAssign(swigCPtr, CExoArrayListCNWLevelStatsPtr.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void** _OpIndex(int i) { 
    System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCNWLevelStatsPtr__OpIndex(swigCPtr, i);
    return (void**)retVal;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWLevelStatsPtr_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWLevelStatsPtr_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCNWLevelStatsPtr_Pack(swigCPtr);
  }

  public void Add(CNWLevelStats t) {
    NWNXLibPINVOKE.CExoArrayListCNWLevelStatsPtr_Add(swigCPtr, CNWLevelStats.getCPtr(t));
  }

  public void Insert(CNWLevelStats t, int k) {
    NWNXLibPINVOKE.CExoArrayListCNWLevelStatsPtr_Insert(swigCPtr, CNWLevelStats.getCPtr(t), k);
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListCNWLevelStatsPtr_DelIndex(swigCPtr, i);
  }

  public void** begin() { 
    System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCNWLevelStatsPtr_begin(swigCPtr);
    return (void**)retVal;
  }

  public void** end() { 
    System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCNWLevelStatsPtr_end(swigCPtr);
    return (void**)retVal;
  }

}

}
