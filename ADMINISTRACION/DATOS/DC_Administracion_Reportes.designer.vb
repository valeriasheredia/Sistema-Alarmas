﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="Administracion")>  _
Partial Public Class DC_Administracion_Reportes
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Definiciones de métodos de extensibilidad"
  Partial Private Sub OnCreated()
  End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.WindowsApplication1.My.MySettings.Default.AdministracionConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.Proc_Ventas_Id")>  _
	Public Function Proc_Ventas_Id(<Global.System.Data.Linq.Mapping.ParameterAttribute(DbType:="Int")> ByVal id_venta As System.Nullable(Of Integer)) As ISingleResult(Of Proc_Ventas_IdResult)
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), id_venta)
		Return CType(result.ReturnValue,ISingleResult(Of Proc_Ventas_IdResult))
	End Function
End Class

Partial Public Class Proc_Ventas_IdResult
	
	Private _ID_PROD_X_VTA As Integer
	
	Private _ID_PRODUCTO As Integer
	
	Private _ID_VENTA As Integer
	
	Private _PXV_CANTIDAD As Integer
	
	Private _PXV_PRECIO_X_PRODUCTO As Decimal
	
	Private _ID_VENTA1 As Integer
	
	Private _VENT_FECHA As Date
	
	Private _VENT_SUBTOTAL As Decimal
	
	Private _VENT_TOTAL As Decimal
	
	Private _VENT_CANTIDAD As Integer
	
	Private _ID_FORM_DE_PAGO As Integer
	
	Private _ID_CLIENTE As System.Nullable(Of Integer)
	
	Private _ID_CLIENTE1 As Integer
	
	Private _CLI_NOMBRES As String
	
	Private _CLI_APELLIDO As String
	
	Private _CLI_DNI As String
	
	Private _CLI_DIRECCION As String
	
	Private _CLI_LOCALIDAD As String
	
	Private _CLI_TEL_1 As String
	
	Private _CLI_TEL_2 As String
	
	Private _CLI_MAIL As String
	
	Private _CLI_TIPO As String
	
	Private _CLI_CONTRATO As String
	
	Private _CLI_FECHA_ALTA As System.Nullable(Of Date)
	
	Private _ID_PRODUCTO1 As Integer
	
	Private _PROD_CODIGO As String
	
	Private _PROD_DESCRIPCION As String
	
	Private _PROD_PRECIO_COSTO As Decimal
	
	Private _PROD_PRECIO_VTA As Decimal
	
	Private _PROD_STOCK As Integer
	
	Private _ID_PROVEEDOR As Integer
	
	Private _ID_DEPOSITO As Integer
	
	Private _ID_PROD_TIPO As Integer
	
	Private _ID_FORM_DE_PAGO1 As Integer
	
	Private _FDP_DESCRIPCION As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID_PROD_X_VTA", DbType:="Int NOT NULL")>  _
	Public Property ID_PROD_X_VTA() As Integer
		Get
			Return Me._ID_PROD_X_VTA
		End Get
		Set
			If ((Me._ID_PROD_X_VTA = value)  _
						= false) Then
				Me._ID_PROD_X_VTA = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID_PRODUCTO", DbType:="Int NOT NULL")>  _
	Public Property ID_PRODUCTO() As Integer
		Get
			Return Me._ID_PRODUCTO
		End Get
		Set
			If ((Me._ID_PRODUCTO = value)  _
						= false) Then
				Me._ID_PRODUCTO = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID_VENTA", DbType:="Int NOT NULL")>  _
	Public Property ID_VENTA() As Integer
		Get
			Return Me._ID_VENTA
		End Get
		Set
			If ((Me._ID_VENTA = value)  _
						= false) Then
				Me._ID_VENTA = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PXV_CANTIDAD", DbType:="Int NOT NULL")>  _
	Public Property PXV_CANTIDAD() As Integer
		Get
			Return Me._PXV_CANTIDAD
		End Get
		Set
			If ((Me._PXV_CANTIDAD = value)  _
						= false) Then
				Me._PXV_CANTIDAD = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PXV_PRECIO_X_PRODUCTO", DbType:="Decimal(7,2) NOT NULL")>  _
	Public Property PXV_PRECIO_X_PRODUCTO() As Decimal
		Get
			Return Me._PXV_PRECIO_X_PRODUCTO
		End Get
		Set
			If ((Me._PXV_PRECIO_X_PRODUCTO = value)  _
						= false) Then
				Me._PXV_PRECIO_X_PRODUCTO = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID_VENTA1", DbType:="Int NOT NULL")>  _
	Public Property ID_VENTA1() As Integer
		Get
			Return Me._ID_VENTA1
		End Get
		Set
			If ((Me._ID_VENTA1 = value)  _
						= false) Then
				Me._ID_VENTA1 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_VENT_FECHA", DbType:="Date NOT NULL")>  _
	Public Property VENT_FECHA() As Date
		Get
			Return Me._VENT_FECHA
		End Get
		Set
			If ((Me._VENT_FECHA = value)  _
						= false) Then
				Me._VENT_FECHA = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_VENT_SUBTOTAL", DbType:="Decimal(7,2) NOT NULL")>  _
	Public Property VENT_SUBTOTAL() As Decimal
		Get
			Return Me._VENT_SUBTOTAL
		End Get
		Set
			If ((Me._VENT_SUBTOTAL = value)  _
						= false) Then
				Me._VENT_SUBTOTAL = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_VENT_TOTAL", DbType:="Decimal(7,2) NOT NULL")>  _
	Public Property VENT_TOTAL() As Decimal
		Get
			Return Me._VENT_TOTAL
		End Get
		Set
			If ((Me._VENT_TOTAL = value)  _
						= false) Then
				Me._VENT_TOTAL = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_VENT_CANTIDAD", DbType:="Int NOT NULL")>  _
	Public Property VENT_CANTIDAD() As Integer
		Get
			Return Me._VENT_CANTIDAD
		End Get
		Set
			If ((Me._VENT_CANTIDAD = value)  _
						= false) Then
				Me._VENT_CANTIDAD = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID_FORM_DE_PAGO", DbType:="Int NOT NULL")>  _
	Public Property ID_FORM_DE_PAGO() As Integer
		Get
			Return Me._ID_FORM_DE_PAGO
		End Get
		Set
			If ((Me._ID_FORM_DE_PAGO = value)  _
						= false) Then
				Me._ID_FORM_DE_PAGO = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID_CLIENTE", DbType:="Int")>  _
	Public Property ID_CLIENTE() As System.Nullable(Of Integer)
		Get
			Return Me._ID_CLIENTE
		End Get
		Set
			If (Me._ID_CLIENTE.Equals(value) = false) Then
				Me._ID_CLIENTE = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID_CLIENTE1", DbType:="Int NOT NULL")>  _
	Public Property ID_CLIENTE1() As Integer
		Get
			Return Me._ID_CLIENTE1
		End Get
		Set
			If ((Me._ID_CLIENTE1 = value)  _
						= false) Then
				Me._ID_CLIENTE1 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CLI_NOMBRES", DbType:="VarChar(30) NOT NULL", CanBeNull:=false)>  _
	Public Property CLI_NOMBRES() As String
		Get
			Return Me._CLI_NOMBRES
		End Get
		Set
			If (String.Equals(Me._CLI_NOMBRES, value) = false) Then
				Me._CLI_NOMBRES = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CLI_APELLIDO", DbType:="VarChar(30) NOT NULL", CanBeNull:=false)>  _
	Public Property CLI_APELLIDO() As String
		Get
			Return Me._CLI_APELLIDO
		End Get
		Set
			If (String.Equals(Me._CLI_APELLIDO, value) = false) Then
				Me._CLI_APELLIDO = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CLI_DNI", DbType:="Char(8) NOT NULL", CanBeNull:=false)>  _
	Public Property CLI_DNI() As String
		Get
			Return Me._CLI_DNI
		End Get
		Set
			If (String.Equals(Me._CLI_DNI, value) = false) Then
				Me._CLI_DNI = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CLI_DIRECCION", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property CLI_DIRECCION() As String
		Get
			Return Me._CLI_DIRECCION
		End Get
		Set
			If (String.Equals(Me._CLI_DIRECCION, value) = false) Then
				Me._CLI_DIRECCION = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CLI_LOCALIDAD", DbType:="VarChar(30) NOT NULL", CanBeNull:=false)>  _
	Public Property CLI_LOCALIDAD() As String
		Get
			Return Me._CLI_LOCALIDAD
		End Get
		Set
			If (String.Equals(Me._CLI_LOCALIDAD, value) = false) Then
				Me._CLI_LOCALIDAD = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CLI_TEL_1", DbType:="VarChar(15) NOT NULL", CanBeNull:=false)>  _
	Public Property CLI_TEL_1() As String
		Get
			Return Me._CLI_TEL_1
		End Get
		Set
			If (String.Equals(Me._CLI_TEL_1, value) = false) Then
				Me._CLI_TEL_1 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CLI_TEL_2", DbType:="VarChar(15)")>  _
	Public Property CLI_TEL_2() As String
		Get
			Return Me._CLI_TEL_2
		End Get
		Set
			If (String.Equals(Me._CLI_TEL_2, value) = false) Then
				Me._CLI_TEL_2 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CLI_MAIL", DbType:="VarChar(50)")>  _
	Public Property CLI_MAIL() As String
		Get
			Return Me._CLI_MAIL
		End Get
		Set
			If (String.Equals(Me._CLI_MAIL, value) = false) Then
				Me._CLI_MAIL = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CLI_TIPO", DbType:="VarChar(10)")>  _
	Public Property CLI_TIPO() As String
		Get
			Return Me._CLI_TIPO
		End Get
		Set
			If (String.Equals(Me._CLI_TIPO, value) = false) Then
				Me._CLI_TIPO = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CLI_CONTRATO", DbType:="VarChar(10)")>  _
	Public Property CLI_CONTRATO() As String
		Get
			Return Me._CLI_CONTRATO
		End Get
		Set
			If (String.Equals(Me._CLI_CONTRATO, value) = false) Then
				Me._CLI_CONTRATO = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CLI_FECHA_ALTA", DbType:="Date")>  _
	Public Property CLI_FECHA_ALTA() As System.Nullable(Of Date)
		Get
			Return Me._CLI_FECHA_ALTA
		End Get
		Set
			If (Me._CLI_FECHA_ALTA.Equals(value) = false) Then
				Me._CLI_FECHA_ALTA = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID_PRODUCTO1", DbType:="Int NOT NULL")>  _
	Public Property ID_PRODUCTO1() As Integer
		Get
			Return Me._ID_PRODUCTO1
		End Get
		Set
			If ((Me._ID_PRODUCTO1 = value)  _
						= false) Then
				Me._ID_PRODUCTO1 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PROD_CODIGO", DbType:="VarChar(30) NOT NULL", CanBeNull:=false)>  _
	Public Property PROD_CODIGO() As String
		Get
			Return Me._PROD_CODIGO
		End Get
		Set
			If (String.Equals(Me._PROD_CODIGO, value) = false) Then
				Me._PROD_CODIGO = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PROD_DESCRIPCION", DbType:="VarChar(100) NOT NULL", CanBeNull:=false)>  _
	Public Property PROD_DESCRIPCION() As String
		Get
			Return Me._PROD_DESCRIPCION
		End Get
		Set
			If (String.Equals(Me._PROD_DESCRIPCION, value) = false) Then
				Me._PROD_DESCRIPCION = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PROD_PRECIO_COSTO", DbType:="Decimal(7,2) NOT NULL")>  _
	Public Property PROD_PRECIO_COSTO() As Decimal
		Get
			Return Me._PROD_PRECIO_COSTO
		End Get
		Set
			If ((Me._PROD_PRECIO_COSTO = value)  _
						= false) Then
				Me._PROD_PRECIO_COSTO = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PROD_PRECIO_VTA", DbType:="Decimal(7,2) NOT NULL")>  _
	Public Property PROD_PRECIO_VTA() As Decimal
		Get
			Return Me._PROD_PRECIO_VTA
		End Get
		Set
			If ((Me._PROD_PRECIO_VTA = value)  _
						= false) Then
				Me._PROD_PRECIO_VTA = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PROD_STOCK", DbType:="Int NOT NULL")>  _
	Public Property PROD_STOCK() As Integer
		Get
			Return Me._PROD_STOCK
		End Get
		Set
			If ((Me._PROD_STOCK = value)  _
						= false) Then
				Me._PROD_STOCK = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID_PROVEEDOR", DbType:="Int NOT NULL")>  _
	Public Property ID_PROVEEDOR() As Integer
		Get
			Return Me._ID_PROVEEDOR
		End Get
		Set
			If ((Me._ID_PROVEEDOR = value)  _
						= false) Then
				Me._ID_PROVEEDOR = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID_DEPOSITO", DbType:="Int NOT NULL")>  _
	Public Property ID_DEPOSITO() As Integer
		Get
			Return Me._ID_DEPOSITO
		End Get
		Set
			If ((Me._ID_DEPOSITO = value)  _
						= false) Then
				Me._ID_DEPOSITO = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID_PROD_TIPO", DbType:="Int NOT NULL")>  _
	Public Property ID_PROD_TIPO() As Integer
		Get
			Return Me._ID_PROD_TIPO
		End Get
		Set
			If ((Me._ID_PROD_TIPO = value)  _
						= false) Then
				Me._ID_PROD_TIPO = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID_FORM_DE_PAGO1", DbType:="Int NOT NULL")>  _
	Public Property ID_FORM_DE_PAGO1() As Integer
		Get
			Return Me._ID_FORM_DE_PAGO1
		End Get
		Set
			If ((Me._ID_FORM_DE_PAGO1 = value)  _
						= false) Then
				Me._ID_FORM_DE_PAGO1 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FDP_DESCRIPCION", DbType:="VarChar(20) NOT NULL", CanBeNull:=false)>  _
	Public Property FDP_DESCRIPCION() As String
		Get
			Return Me._FDP_DESCRIPCION
		End Get
		Set
			If (String.Equals(Me._FDP_DESCRIPCION, value) = false) Then
				Me._FDP_DESCRIPCION = value
			End If
		End Set
	End Property
End Class