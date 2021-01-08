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

public class CLoopingVisualEffect : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CLoopingVisualEffect(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CLoopingVisualEffect obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CLoopingVisualEffect() {
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

  public ushort m_nId {
    set {
      NWNXLibPINVOKE.CLoopingVisualEffect_m_nId_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CLoopingVisualEffect_m_nId_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oOriginator {
    set {
      NWNXLibPINVOKE.CLoopingVisualEffect_m_oOriginator_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CLoopingVisualEffect_m_oOriginator_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nBodyPart {
    set {
      NWNXLibPINVOKE.CLoopingVisualEffect_m_nBodyPart_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CLoopingVisualEffect_m_nBodyPart_get(swigCPtr);
      return ret;
    } 
  }

  public ObjectVisualTransformData m_ovtd {
    set {
      NWNXLibPINVOKE.CLoopingVisualEffect_m_ovtd_set(swigCPtr, ObjectVisualTransformData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CLoopingVisualEffect_m_ovtd_get(swigCPtr);
      ObjectVisualTransformData ret = (cPtr == global::System.IntPtr.Zero) ? null : new ObjectVisualTransformData(cPtr, false);
      return ret;
    } 
  }

  public int GetIsBeam() {
    int ret = NWNXLibPINVOKE.CLoopingVisualEffect_GetIsBeam(swigCPtr);
    return ret;
  }

}

}