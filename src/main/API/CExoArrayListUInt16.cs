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

public unsafe class CExoArrayListUInt16 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CExoArrayListUInt16(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CExoArrayListUInt16(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListUInt16 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListUInt16() {
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
          NWNXLibPINVOKE.delete_CExoArrayListUInt16(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListUInt16 self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CExoArrayListUInt16 self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CExoArrayListUInt16 other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListUInt16 other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListUInt16 left, CExoArrayListUInt16 right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListUInt16 left, CExoArrayListUInt16 right) {
    return !Equals(left, right);
  }

  public ushort* element {
    set {
      NWNXLibPINVOKE.CExoArrayListUInt16_element_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListUInt16_element_get(swigCPtr); 
        return (ushort*)retVal; 
    }

  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListUInt16_num_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListUInt16_num_get(swigCPtr);
      return ret;
    } 
  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListUInt16_array_size_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListUInt16_array_size_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListUInt16(int s) : this(NWNXLibPINVOKE.new_CExoArrayListUInt16__SWIG_0(s), true) {
  }

  public CExoArrayListUInt16() : this(NWNXLibPINVOKE.new_CExoArrayListUInt16__SWIG_1(), true) {
  }

  public CExoArrayListUInt16(CExoArrayListUInt16 list) : this(NWNXLibPINVOKE.new_CExoArrayListUInt16__SWIG_2(CExoArrayListUInt16.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListUInt16 _OpAssign(CExoArrayListUInt16 list) {
    CExoArrayListUInt16 ret = new CExoArrayListUInt16(NWNXLibPINVOKE.CExoArrayListUInt16__OpAssign(swigCPtr, CExoArrayListUInt16.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort* _OpIndex(int i) { 
    System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListUInt16__OpIndex(swigCPtr, i);
    return (ushort*)retVal;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListUInt16_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListUInt16_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListUInt16_Pack(swigCPtr);
  }

  public void Add(ushort t) {
    NWNXLibPINVOKE.CExoArrayListUInt16_Add(swigCPtr, t);
  }

  public void Insert(ushort t, int k) {
    NWNXLibPINVOKE.CExoArrayListUInt16_Insert(swigCPtr, t, k);
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListUInt16_DelIndex(swigCPtr, i);
  }

  public ushort* begin() { 
    System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListUInt16_begin(swigCPtr);
    return (ushort*)retVal;
  }

  public ushort* end() { 
    System.IntPtr retVal = NWNXLibPINVOKE.CExoArrayListUInt16_end(swigCPtr);
    return (ushort*)retVal;
  }

}

}
