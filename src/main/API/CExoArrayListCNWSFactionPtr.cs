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

public unsafe class CExoArrayListCNWSFactionPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CExoArrayListCNWSFactionPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CExoArrayListCNWSFactionPtr(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCNWSFactionPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCNWSFactionPtr() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCNWSFactionPtr(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListCNWSFactionPtr self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CExoArrayListCNWSFactionPtr self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CExoArrayListCNWSFactionPtr other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListCNWSFactionPtr other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListCNWSFactionPtr left, CExoArrayListCNWSFactionPtr right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListCNWSFactionPtr left, CExoArrayListCNWSFactionPtr right) {
    return !Equals(left, right);
  }

  public void** element {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_element_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_element_get(swigCPtr); 
        return (void**)retVal; 
    }

  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_num_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_num_get(swigCPtr);
      return ret;
    } 
  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_array_size_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_array_size_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListCNWSFactionPtr(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCNWSFactionPtr__SWIG_0(s), true) {
  }

  public CExoArrayListCNWSFactionPtr() : this(NWNXLibPINVOKE.new_CExoArrayListCNWSFactionPtr__SWIG_1(), true) {
  }

  public CExoArrayListCNWSFactionPtr(CExoArrayListCNWSFactionPtr list) : this(NWNXLibPINVOKE.new_CExoArrayListCNWSFactionPtr__SWIG_2(CExoArrayListCNWSFactionPtr.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListCNWSFactionPtr _OpAssign(CExoArrayListCNWSFactionPtr list) {
    CExoArrayListCNWSFactionPtr ret = new CExoArrayListCNWSFactionPtr(NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr__OpAssign(swigCPtr, CExoArrayListCNWSFactionPtr.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void** _OpIndex(int i) { 
    System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr__OpIndex(swigCPtr, i);
    return (void**)retVal;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_Pack(swigCPtr);
  }

  public void Add(CNWSFaction t) {
    NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_Add(swigCPtr, CNWSFaction.getCPtr(t));
  }

  public void Insert(CNWSFaction t, int k) {
    NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_Insert(swigCPtr, CNWSFaction.getCPtr(t), k);
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_DelIndex(swigCPtr, i);
  }

  public void** begin() { 
    System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_begin(swigCPtr);
    return (void**)retVal;
  }

  public void** end() { 
    System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListCNWSFactionPtr_end(swigCPtr);
    return (void**)retVal;
  }

}

}
