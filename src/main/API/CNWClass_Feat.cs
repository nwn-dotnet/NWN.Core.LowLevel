//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NWN.Native.API {

public class CNWClass_Feat : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWClass_Feat(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWClass_Feat obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWClass_Feat() {
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
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ushort nFeat {
    set {
      NWNXLibPINVOKE.CNWClass_Feat_nFeat_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWClass_Feat_nFeat_get(swigCPtr);
      return ret;
    } 
  }

  public byte nLevelGranted {
    set {
      NWNXLibPINVOKE.CNWClass_Feat_nLevelGranted_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWClass_Feat_nLevelGranted_get(swigCPtr);
      return ret;
    } 
  }

  public byte nListType {
    set {
      NWNXLibPINVOKE.CNWClass_Feat_nListType_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWClass_Feat_nListType_get(swigCPtr);
      return ret;
    } 
  }

  public int nTalentCategory {
    set {
      NWNXLibPINVOKE.CNWClass_Feat_nTalentCategory_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWClass_Feat_nTalentCategory_get(swigCPtr);
      return ret;
    } 
  }

  public int nMaxCR {
    set {
      NWNXLibPINVOKE.CNWClass_Feat_nMaxCR_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWClass_Feat_nMaxCR_get(swigCPtr);
      return ret;
    } 
  }

  public int nOnClassRadial {
    set {
      NWNXLibPINVOKE.CNWClass_Feat_nOnClassRadial_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWClass_Feat_nOnClassRadial_get(swigCPtr);
      return ret;
    } 
  }

}

}