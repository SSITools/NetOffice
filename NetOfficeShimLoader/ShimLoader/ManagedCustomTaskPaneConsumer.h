#pragma once
#include "stdafx.h"
#include "ICTPFactory.h"

extern HINSTANCE _module;
extern ULONG _components;
extern ULONG _locks;

class ManagedCustomTaskPaneConsumer : public ICustomTaskPaneConsumer
{

public:

	// Ctor, Dtor
	ManagedCustomTaskPaneConsumer(ICustomTaskPaneConsumer* innerConsumer);
	~ManagedCustomTaskPaneConsumer();

	// ICustomTaskPaneConsumer Implementation
	STDMETHOD(CTPFactoryAvailable) (ICTPFactory* CTPFactoryInst);

	// IDispatch Implementation
	STDMETHODIMP GetTypeInfoCount(UINT* pctinfo);
	STDMETHODIMP GetTypeInfo(UINT iTInfo, LCID lcid, ITypeInfo** ppTInfo);
	STDMETHODIMP GetIDsOfNames(REFIID riid, LPOLESTR* rgszNames, UINT cNames, LCID lcid, DISPID* rgDispId);
	STDMETHODIMP Invoke(DISPID dispIdMember, REFIID riid, LCID lcid, WORD wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, UINT* puArgErr);

	// IUnknown Implementation
	STDMETHODIMP         QueryInterface(REFIID riid, void ** ppv);
	STDMETHODIMP_(ULONG) AddRef(void);
	STDMETHODIMP_(ULONG) Release(void);

private:

	ICustomTaskPaneConsumer*	_innerConsumer;
	ULONG						_refCounter;

};
