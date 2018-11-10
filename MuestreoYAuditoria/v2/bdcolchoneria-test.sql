-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 10-11-2018 a las 06:43:11
-- Versión del servidor: 10.1.35-MariaDB
-- Versión de PHP: 7.2.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bdcolchoneria`
--

CREATE DATABASE bdcolchoneria;
USE bdcolchoneria;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_bodega`
--

CREATE TABLE `tbl_bodega` (
  `PK_Codigo_bodega` int(11) NOT NULL,
  `Nombre_Bodega` varchar(45) DEFAULT NULL,
  `Encargado` varchar(45) DEFAULT NULL,
  `Tipo_Bodega` varchar(45) DEFAULT NULL,
  `Ubicacion_Bodega` varchar(45) DEFAULT NULL,
  `estatus` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_bodega`
--

INSERT INTO `tbl_bodega` (`PK_Codigo_bodega`, `Nombre_Bodega`, `Encargado`, `Tipo_Bodega`, `Ubicacion_Bodega`, `estatus`) VALUES
(1, 'BODEGA A', 'JOSE', 'BODEGA CENTRAL', '4 CALLE', 0),
(2, 'BODEGA B', 'MARIO', 'SUCURSAL', 'ZONA 10', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_cotizaciondetalle`
--

CREATE TABLE `tbl_cotizaciondetalle` (
  `PK_Codigo_DetalleCotizacion` int(11) NOT NULL,
  `Cantidad` int(11) DEFAULT NULL,
  `Subtotal` decimal(10,0) DEFAULT NULL,
  `FK_EncabezadoCotizacion` int(11) NOT NULL,
  `FK_Producto` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_cotizacionencabezado`
--

CREATE TABLE `tbl_cotizacionencabezado` (
  `PK_NumeroDeCotizacion` int(11) NOT NULL,
  `NombreDelSolicitante` varchar(55) DEFAULT NULL,
  `FechaDeOrden` date DEFAULT NULL,
  `Total` decimal(10,0) DEFAULT NULL,
  `estatus` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_destino`
--

CREATE TABLE `tbl_destino` (
  `PK_correlativo_destino` int(11) NOT NULL,
  `direccion` varchar(80) DEFAULT NULL,
  `latitud` int(11) DEFAULT NULL,
  `longitud` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_detalleinventariobodega`
--

CREATE TABLE `tbl_detalleinventariobodega` (
  `PK_DetalleInventarioBodega` int(11) NOT NULL,
  `FK_Cod_Enca` int(11) NOT NULL,
  `FK_Codigo_Producto` int(11) NOT NULL,
  `FK_id_Sede` int(11) NOT NULL,
  `stock` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_detalleinventariobodega`
--

INSERT INTO `tbl_detalleinventariobodega` (`PK_DetalleInventarioBodega`, `FK_Cod_Enca`, `FK_Codigo_Producto`, `FK_id_Sede`, `stock`) VALUES
(1, 1, 1, 1, 0),
(2, 1, 2, 1, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_detalle_doc_inventario`
--

CREATE TABLE `tbl_detalle_doc_inventario` (
  `FK_Enc_Doc_Inventario` int(11) NOT NULL,
  `FK_Codigo_Producto` int(11) NOT NULL,
  `FK_DetalleInventarioBodega` int(11) NOT NULL,
  `Cantidad_producto` int(11) DEFAULT NULL,
  `precio` double DEFAULT NULL,
  `Total` double DEFAULT NULL,
  `costo` double DEFAULT NULL,
  `estatus` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_detalle_envio`
--

CREATE TABLE `tbl_detalle_envio` (
  `PK_Codigo_Detalle_Envio` int(11) NOT NULL,
  `Descripcion_Producto` varchar(45) NOT NULL,
  `No_Total_Productos` int(11) NOT NULL,
  `FK_Codigo_Producto` int(11) NOT NULL,
  `FK_Codigo_Encabezado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_doc_auditoria`
--

CREATE TABLE `tbl_doc_auditoria` (
  `PK_Id_Doc_Auditoria` int(11) NOT NULL,
  `FK_Codigo_bodega` int(11) NOT NULL,
  `Fecha` date DEFAULT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  `estatus` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_doc_auditoria`
--

INSERT INTO `tbl_doc_auditoria` (`PK_Id_Doc_Auditoria`, `FK_Codigo_bodega`, `Fecha`, `Descripcion`, `estatus`) VALUES
(1, 1, '2018-11-04', 'AUDITORIA TEST', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_encainventariobodega`
--

CREATE TABLE `tbl_encainventariobodega` (
  `PK_Cod_Enca` int(11) NOT NULL,
  `FK_Codigo_bodega` int(11) NOT NULL,
  `Enca_Fecha` date NOT NULL,
  `estatus` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_encainventariobodega`
--

INSERT INTO `tbl_encainventariobodega` (`PK_Cod_Enca`, `FK_Codigo_bodega`, `Enca_Fecha`, `estatus`) VALUES
(1, 1, '2018-11-04', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_enc_doc_inventario`
--

CREATE TABLE `tbl_enc_doc_inventario` (
  `PK_Enc_Doc_Inventario` int(11) NOT NULL,
  `FK_Opc_inventario` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `estatus` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_entrega_producto_historial`
--

CREATE TABLE `tbl_entrega_producto_historial` (
  `PK_Correlativo_Producto_Historial` int(11) NOT NULL,
  `Ruta_detalle_correlativo` int(11) DEFAULT NULL,
  `Codigo_Producto` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_envio_encabezado`
--

CREATE TABLE `tbl_envio_encabezado` (
  `PK_Codigo_Encabezado_Envio` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Punto_origen` varchar(45) NOT NULL,
  `FK_id_Sede` int(11) NOT NULL,
  `FK_correlativo_destino` int(11) NOT NULL,
  `FK_id_Vehiculos` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_grupo_de_productos`
--

CREATE TABLE `tbl_grupo_de_productos` (
  `PK_Codigo_Grupo_de_Productos` int(11) NOT NULL,
  `Nombre_de_Grupo_de_Productos` varchar(45) DEFAULT NULL,
  `estatus` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_grupo_de_productos`
--

INSERT INTO `tbl_grupo_de_productos` (`PK_Codigo_Grupo_de_Productos`, `Nombre_de_Grupo_de_Productos`, `estatus`) VALUES
(1, 'GRUPO A', 0),
(2, 'GRUPO B', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_historico_producto`
--

CREATE TABLE `tbl_historico_producto` (
  `PK_Codigo_Producto` int(11) NOT NULL,
  `FK_GrupoProductos` int(11) NOT NULL,
  `FK_Marca` int(11) NOT NULL,
  `FK_Moneda` int(11) NOT NULL,
  `FK_UnidadDeMedida` int(11) NOT NULL,
  `FK_Tipo_Producto` int(11) NOT NULL,
  `Descripcion_Producto` varchar(30) NOT NULL,
  `cargo_Producto` int(11) NOT NULL,
  `cargo_Acumulado_Producto` int(11) NOT NULL,
  `abono_Producto` int(11) NOT NULL,
  `abono_Acumulado_Producto` int(11) NOT NULL,
  `saldo_Actual` int(11) NOT NULL,
  `saldo_Anterior` int(11) NOT NULL,
  `Precio` double NOT NULL,
  `costo` double NOT NULL,
  `estatus` int(11) NOT NULL,
  `TBL_Respaldos_PK_codigo_respaldo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_marca`
--

CREATE TABLE `tbl_marca` (
  `PK_id_Linea` int(11) NOT NULL,
  `Nombre` varchar(30) NOT NULL,
  `Serie` varchar(30) NOT NULL,
  `Año` date NOT NULL,
  `FK_Modelo` int(11) NOT NULL,
  `estatus` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_modelo`
--

CREATE TABLE `tbl_modelo` (
  `PK_id_modelo` int(11) NOT NULL,
  `Nombre` varchar(30) NOT NULL,
  `estatus` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_muestra_auditoria`
--

CREATE TABLE `tbl_muestra_auditoria` (
  `PK_Id_Doc_Auditoria` int(11) NOT NULL,
  `PK_Codigo_Producto` int(11) NOT NULL,
  `Cantidad_Logica` int(11) DEFAULT NULL,
  `Cantidad_Fisica` int(11) DEFAULT NULL,
  `Diferencia` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_muestra_auditoria`
--

INSERT INTO `tbl_muestra_auditoria` (`PK_Id_Doc_Auditoria`, `PK_Codigo_Producto`, `Cantidad_Logica`, `Cantidad_Fisica`, `Diferencia`) VALUES
(1, 1, 0, 0, 0),
(1, 2, 0, 0, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_operaciones_inv`
--

CREATE TABLE `tbl_operaciones_inv` (
  `PK_Opc_inventario` int(11) NOT NULL,
  `Tipo_Operacion_Inv` int(11) DEFAULT NULL,
  `Id_Cuenta` int(11) DEFAULT NULL,
  `estatus` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_ordendecompradetalle`
--

CREATE TABLE `tbl_ordendecompradetalle` (
  `PK_Codigo_DetalleOrdenDeCompra` int(11) NOT NULL,
  `Cantidad` int(11) DEFAULT NULL,
  `Subtotal` decimal(10,0) DEFAULT NULL,
  `FK_EncabezadoOrden` int(11) NOT NULL,
  `FK_Productos` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_ordendecompraencabezado`
--

CREATE TABLE `tbl_ordendecompraencabezado` (
  `PK_NumeroOrden` int(11) NOT NULL,
  `NombreDelSolicitante` varchar(55) DEFAULT NULL,
  `FechaDeOrden` date DEFAULT NULL,
  `FechaDeLaEntrega` date DEFAULT NULL,
  `EstadoDeAutorizacion` int(11) DEFAULT NULL,
  `estatus` int(11) DEFAULT NULL,
  `Total` decimal(10,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_ordendedevoluciondetalle`
--

CREATE TABLE `tbl_ordendedevoluciondetalle` (
  `PK_Codigo_DetalleOrdenDeDevolucion` int(11) NOT NULL,
  `Cantidad` int(11) DEFAULT NULL,
  `Subtotal` decimal(10,0) DEFAULT NULL,
  `FK_EncabezadoOrden` int(11) NOT NULL,
  `FK_Producto` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_ordendedevolucionencabezado`
--

CREATE TABLE `tbl_ordendedevolucionencabezado` (
  `PK_NumeroOrden` int(11) NOT NULL,
  `NombreDelSolicitante` varchar(55) DEFAULT NULL,
  `FechaDeOrden` date DEFAULT NULL,
  `EstadoDeAutorizacion` int(11) DEFAULT NULL,
  `Motivo` varchar(55) DEFAULT NULL,
  `Total` decimal(10,0) DEFAULT NULL,
  `estatus` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_producto`
--

CREATE TABLE `tbl_producto` (
  `PK_Codigo_Producto` int(11) NOT NULL,
  `FK_GrupoProductos` int(11) NOT NULL,
  `FK_Moneda` int(11) NOT NULL,
  `FK_UnidadDeMedida` int(11) NOT NULL,
  `FK_Tipo_Producto` int(11) NOT NULL,
  `Descripcion_Producto` varchar(30) NOT NULL,
  `cargo_Producto` int(11) NOT NULL,
  `cargo_Acumulado_Producto` int(11) NOT NULL,
  `abono_Producto` int(11) NOT NULL,
  `abono_Acumulado_Producto` int(11) NOT NULL,
  `saldo_Actual` int(11) NOT NULL,
  `saldo_Anterior` int(11) NOT NULL,
  `Precio` double NOT NULL,
  `costo` double NOT NULL,
  `estatus` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_producto`
--

INSERT INTO `tbl_producto` (`PK_Codigo_Producto`, `FK_GrupoProductos`, `FK_Moneda`, `FK_UnidadDeMedida`, `FK_Tipo_Producto`, `Descripcion_Producto`, `cargo_Producto`, `cargo_Acumulado_Producto`, `abono_Producto`, `abono_Acumulado_Producto`, `saldo_Actual`, `saldo_Anterior`, `Precio`, `costo`, `estatus`) VALUES
(1, 2, 1, 2, 2, 'ALGODONES', 10, 0, 0, 0, 0, 0, 100, 50.2, 0),
(2, 1, 1, 1, 2, 'NDAA', 100, 0, 0, 0, 0, 0, 20.2, 5.6, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_respaldos`
--

CREATE TABLE `tbl_respaldos` (
  `PK_codigo_respaldo` int(11) NOT NULL,
  `Fecha` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_ruta_detalle`
--

CREATE TABLE `tbl_ruta_detalle` (
  `PK_ruta_detalle_correlativo` int(11) NOT NULL,
  `id_encabezado` int(11) DEFAULT NULL,
  `destino_id` int(11) DEFAULT NULL,
  `fecha` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_ruta_encabezado`
--

CREATE TABLE `tbl_ruta_encabezado` (
  `PK_Correlativo_ruta` int(11) NOT NULL,
  `vehiculo_id` int(11) DEFAULT NULL,
  `fecha_creacion` datetime DEFAULT NULL,
  `envio_id` int(11) DEFAULT NULL,
  `descripcion_ruta` varchar(80) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_sede`
--

CREATE TABLE `tbl_sede` (
  `PK_id_Sede` int(11) NOT NULL,
  `Direccion` varchar(45) NOT NULL,
  `Telefono` varchar(45) NOT NULL,
  `Correo` varchar(45) NOT NULL,
  `estatus` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_sede`
--

INSERT INTO `tbl_sede` (`PK_id_Sede`, `Direccion`, `Telefono`, `Correo`, `estatus`) VALUES
(1, 'zona 4', '12345', 'correo', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_tipo_producto`
--

CREATE TABLE `tbl_tipo_producto` (
  `PK_Id_Tipo_Pro` int(11) NOT NULL,
  `Tipo_Producto` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_tipo_producto`
--

INSERT INTO `tbl_tipo_producto` (`PK_Id_Tipo_Pro`, `Tipo_Producto`) VALUES
(1, 'TIPO A'),
(2, 'TIPO B');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_unidaddemedidabase`
--

CREATE TABLE `tbl_unidaddemedidabase` (
  `PK_CodigoDeUnidadDeMedidaBase` int(11) NOT NULL,
  `UnidadDeMedida` varchar(45) DEFAULT NULL,
  `estatus` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_unidaddemedidabase`
--

INSERT INTO `tbl_unidaddemedidabase` (`PK_CodigoDeUnidadDeMedidaBase`, `UnidadDeMedida`, `estatus`) VALUES
(1, 'CENTIMETRO', 0),
(2, 'METRO', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_vehiculos`
--

CREATE TABLE `tbl_vehiculos` (
  `PK_id_Vehiculos` int(11) NOT NULL,
  `Color` varchar(45) DEFAULT NULL,
  `Modelo` int(11) NOT NULL,
  `FK_Modelo` int(11) NOT NULL,
  `estatus` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tbl_bodega`
--
ALTER TABLE `tbl_bodega`
  ADD PRIMARY KEY (`PK_Codigo_bodega`);

--
-- Indices de la tabla `tbl_cotizaciondetalle`
--
ALTER TABLE `tbl_cotizaciondetalle`
  ADD PRIMARY KEY (`PK_Codigo_DetalleCotizacion`,`FK_EncabezadoCotizacion`,`FK_Producto`),
  ADD KEY `fk_TBL_OrdenDeCompraDetalle_TBL_OrdenDeCompraEncabezado1_idx` (`FK_EncabezadoCotizacion`),
  ADD KEY `fk_TBL_CotizacionDetalle_TBL_Producto1_idx` (`FK_Producto`);

--
-- Indices de la tabla `tbl_cotizacionencabezado`
--
ALTER TABLE `tbl_cotizacionencabezado`
  ADD PRIMARY KEY (`PK_NumeroDeCotizacion`);

--
-- Indices de la tabla `tbl_destino`
--
ALTER TABLE `tbl_destino`
  ADD PRIMARY KEY (`PK_correlativo_destino`);

--
-- Indices de la tabla `tbl_detalleinventariobodega`
--
ALTER TABLE `tbl_detalleinventariobodega`
  ADD PRIMARY KEY (`PK_DetalleInventarioBodega`,`FK_Cod_Enca`,`FK_Codigo_Producto`,`FK_id_Sede`),
  ADD KEY `fk_TBL_InventarioBodega_TBL_Producto1_idx` (`FK_Codigo_Producto`),
  ADD KEY `fk_TBL_DetalleInventarioBodega_TBL_EncaInventarioBodega1_idx` (`FK_Cod_Enca`),
  ADD KEY `fk_TBL_DetalleInventarioBodega_TBL_Sede1_idx` (`FK_id_Sede`);

--
-- Indices de la tabla `tbl_detalle_doc_inventario`
--
ALTER TABLE `tbl_detalle_doc_inventario`
  ADD PRIMARY KEY (`FK_Enc_Doc_Inventario`,`FK_Codigo_Producto`,`FK_DetalleInventarioBodega`),
  ADD KEY `fk_TBL_Doc_Inventario_TBL_Producto1_idx` (`FK_Codigo_Producto`),
  ADD KEY `fk_TBL_Doc_Inventario_TBL_Enc_Doc_Inventario1_idx` (`FK_Enc_Doc_Inventario`),
  ADD KEY `fk_TBL_Detalle_Doc_Inventario_TBL_DetalleInventarioBodega1_idx` (`FK_DetalleInventarioBodega`);

--
-- Indices de la tabla `tbl_detalle_envio`
--
ALTER TABLE `tbl_detalle_envio`
  ADD PRIMARY KEY (`PK_Codigo_Detalle_Envio`,`FK_Codigo_Producto`,`FK_Codigo_Encabezado`),
  ADD KEY `fk_TBL_Detalle_Envio_TBL_Producto1_idx` (`FK_Codigo_Producto`),
  ADD KEY `fk_TBL_Detalle_Envio_TBL_Envio_Encabezado1_idx` (`FK_Codigo_Encabezado`);

--
-- Indices de la tabla `tbl_doc_auditoria`
--
ALTER TABLE `tbl_doc_auditoria`
  ADD PRIMARY KEY (`PK_Id_Doc_Auditoria`,`FK_Codigo_bodega`),
  ADD KEY `fk_TBL_Doc_Auditoria_TBL_Bodega1_idx` (`FK_Codigo_bodega`);

--
-- Indices de la tabla `tbl_encainventariobodega`
--
ALTER TABLE `tbl_encainventariobodega`
  ADD PRIMARY KEY (`PK_Cod_Enca`,`FK_Codigo_bodega`),
  ADD KEY `fk_TBL_EncaInventarioBodega_TBL_Bodega1_idx` (`FK_Codigo_bodega`);

--
-- Indices de la tabla `tbl_enc_doc_inventario`
--
ALTER TABLE `tbl_enc_doc_inventario`
  ADD PRIMARY KEY (`PK_Enc_Doc_Inventario`,`FK_Opc_inventario`),
  ADD KEY `fk_TBL_Enc_Doc_Inventario_TBL_Operaciones_Inv1_idx` (`FK_Opc_inventario`);

--
-- Indices de la tabla `tbl_entrega_producto_historial`
--
ALTER TABLE `tbl_entrega_producto_historial`
  ADD PRIMARY KEY (`PK_Correlativo_Producto_Historial`),
  ADD KEY `ruta_detalle_historial_fk_idx` (`Ruta_detalle_correlativo`),
  ADD KEY `codigo_producto_historial_fk_idx` (`Codigo_Producto`);

--
-- Indices de la tabla `tbl_envio_encabezado`
--
ALTER TABLE `tbl_envio_encabezado`
  ADD PRIMARY KEY (`PK_Codigo_Encabezado_Envio`,`FK_id_Sede`,`FK_correlativo_destino`,`FK_id_Vehiculos`),
  ADD KEY `fk_TBL_Envio_Encabezado_TBL_Sede1_idx` (`FK_id_Sede`),
  ADD KEY `fk_TBL_Envio_Encabezado_TBL_Destino1_idx` (`FK_correlativo_destino`),
  ADD KEY `fk_TBL_Envio_Encabezado_TBL_Vehiculos1_idx` (`FK_id_Vehiculos`);

--
-- Indices de la tabla `tbl_grupo_de_productos`
--
ALTER TABLE `tbl_grupo_de_productos`
  ADD PRIMARY KEY (`PK_Codigo_Grupo_de_Productos`);

--
-- Indices de la tabla `tbl_historico_producto`
--
ALTER TABLE `tbl_historico_producto`
  ADD PRIMARY KEY (`PK_Codigo_Producto`,`FK_GrupoProductos`,`FK_Moneda`,`FK_UnidadDeMedida`,`FK_Tipo_Producto`),
  ADD KEY `fk_Producto_Grupo_de_Productos1_idx` (`FK_GrupoProductos`),
  ADD KEY `fk_Producto_marca_idx` (`FK_Marca`),
  ADD KEY `fk_TBL_Producto_UnidadDeMedidaBase1_idx` (`FK_UnidadDeMedida`),
  ADD KEY `fk_TBL_Producto_TBL_Tipo_Producto1_idx` (`FK_Tipo_Producto`),
  ADD KEY `fk_TBL_Historico_Producto_TBL_Respaldos1_idx` (`TBL_Respaldos_PK_codigo_respaldo`);

--
-- Indices de la tabla `tbl_marca`
--
ALTER TABLE `tbl_marca`
  ADD PRIMARY KEY (`PK_id_Linea`),
  ADD KEY `FK_idmarca_idx` (`FK_Modelo`);

--
-- Indices de la tabla `tbl_modelo`
--
ALTER TABLE `tbl_modelo`
  ADD PRIMARY KEY (`PK_id_modelo`);

--
-- Indices de la tabla `tbl_muestra_auditoria`
--
ALTER TABLE `tbl_muestra_auditoria`
  ADD PRIMARY KEY (`PK_Id_Doc_Auditoria`,`PK_Codigo_Producto`),
  ADD KEY `fk_TBL_Muestra_Auditoria_TBL_Producto1_idx` (`PK_Codigo_Producto`),
  ADD KEY `fk_TBL_Muestra_Auditoria_TBL_Doc_Auditoria1_idx` (`PK_Id_Doc_Auditoria`);

--
-- Indices de la tabla `tbl_operaciones_inv`
--
ALTER TABLE `tbl_operaciones_inv`
  ADD PRIMARY KEY (`PK_Opc_inventario`);

--
-- Indices de la tabla `tbl_ordendecompradetalle`
--
ALTER TABLE `tbl_ordendecompradetalle`
  ADD PRIMARY KEY (`PK_Codigo_DetalleOrdenDeCompra`,`FK_EncabezadoOrden`,`FK_Productos`),
  ADD KEY `fk_TBL_OrdenDeCompraDetalle_TBL_OrdenDeCompraEncabezado1_idx` (`FK_EncabezadoOrden`),
  ADD KEY `fk_TBL_OrdenDeCompraDetalle_TBL_Producto1_idx` (`FK_Productos`);

--
-- Indices de la tabla `tbl_ordendecompraencabezado`
--
ALTER TABLE `tbl_ordendecompraencabezado`
  ADD PRIMARY KEY (`PK_NumeroOrden`);

--
-- Indices de la tabla `tbl_ordendedevoluciondetalle`
--
ALTER TABLE `tbl_ordendedevoluciondetalle`
  ADD PRIMARY KEY (`PK_Codigo_DetalleOrdenDeDevolucion`,`FK_EncabezadoOrden`,`FK_Producto`),
  ADD KEY `fk_TBL_OrdenDeCompraDetalle_TBL_OrdenDeCompraEncabezado1_idx` (`FK_EncabezadoOrden`),
  ADD KEY `fk_TBL_OrdenDeDevolucionDetalle_TBL_Producto1_idx` (`FK_Producto`);

--
-- Indices de la tabla `tbl_ordendedevolucionencabezado`
--
ALTER TABLE `tbl_ordendedevolucionencabezado`
  ADD PRIMARY KEY (`PK_NumeroOrden`);

--
-- Indices de la tabla `tbl_producto`
--
ALTER TABLE `tbl_producto`
  ADD PRIMARY KEY (`PK_Codigo_Producto`,`FK_GrupoProductos`,`FK_Moneda`,`FK_UnidadDeMedida`,`FK_Tipo_Producto`),
  ADD KEY `fk_Producto_Grupo_de_Productos1_idx` (`FK_GrupoProductos`),
  ADD KEY `fk_TBL_Producto_UnidadDeMedidaBase1_idx` (`FK_UnidadDeMedida`),
  ADD KEY `fk_TBL_Producto_TBL_Tipo_Producto1_idx` (`FK_Tipo_Producto`);

--
-- Indices de la tabla `tbl_respaldos`
--
ALTER TABLE `tbl_respaldos`
  ADD PRIMARY KEY (`PK_codigo_respaldo`);

--
-- Indices de la tabla `tbl_ruta_detalle`
--
ALTER TABLE `tbl_ruta_detalle`
  ADD PRIMARY KEY (`PK_ruta_detalle_correlativo`),
  ADD KEY `fk_ruta_detalle_idx` (`id_encabezado`),
  ADD KEY `fk_ruta_detalle_destino_idx` (`destino_id`);

--
-- Indices de la tabla `tbl_ruta_encabezado`
--
ALTER TABLE `tbl_ruta_encabezado`
  ADD PRIMARY KEY (`PK_Correlativo_ruta`);

--
-- Indices de la tabla `tbl_sede`
--
ALTER TABLE `tbl_sede`
  ADD PRIMARY KEY (`PK_id_Sede`);

--
-- Indices de la tabla `tbl_tipo_producto`
--
ALTER TABLE `tbl_tipo_producto`
  ADD PRIMARY KEY (`PK_Id_Tipo_Pro`);

--
-- Indices de la tabla `tbl_unidaddemedidabase`
--
ALTER TABLE `tbl_unidaddemedidabase`
  ADD PRIMARY KEY (`PK_CodigoDeUnidadDeMedidaBase`);

--
-- Indices de la tabla `tbl_vehiculos`
--
ALTER TABLE `tbl_vehiculos`
  ADD PRIMARY KEY (`PK_id_Vehiculos`,`FK_Modelo`),
  ADD KEY `fk_TBL_Vehiculos_TBL_Marca1_idx` (`FK_Modelo`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `tbl_bodega`
--
ALTER TABLE `tbl_bodega`
  MODIFY `PK_Codigo_bodega` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tbl_destino`
--
ALTER TABLE `tbl_destino`
  MODIFY `PK_correlativo_destino` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_entrega_producto_historial`
--
ALTER TABLE `tbl_entrega_producto_historial`
  MODIFY `PK_Correlativo_Producto_Historial` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_marca`
--
ALTER TABLE `tbl_marca`
  MODIFY `PK_id_Linea` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_modelo`
--
ALTER TABLE `tbl_modelo`
  MODIFY `PK_id_modelo` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_ruta_detalle`
--
ALTER TABLE `tbl_ruta_detalle`
  MODIFY `PK_ruta_detalle_correlativo` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_ruta_encabezado`
--
ALTER TABLE `tbl_ruta_encabezado`
  MODIFY `PK_Correlativo_ruta` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tbl_sede`
--
ALTER TABLE `tbl_sede`
  MODIFY `PK_id_Sede` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `tbl_vehiculos`
--
ALTER TABLE `tbl_vehiculos`
  MODIFY `PK_id_Vehiculos` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tbl_cotizaciondetalle`
--
ALTER TABLE `tbl_cotizaciondetalle`
  ADD CONSTRAINT `fk_TBL_CotizacionDetalle_TBL_Producto1` FOREIGN KEY (`FK_Producto`) REFERENCES `tbl_producto` (`PK_Codigo_Producto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_TBL_OrdenDeCompraDetalle_TBL_OrdenDeCompraEncabezado11` FOREIGN KEY (`FK_EncabezadoCotizacion`) REFERENCES `tbl_cotizacionencabezado` (`PK_NumeroDeCotizacion`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_detalleinventariobodega`
--
ALTER TABLE `tbl_detalleinventariobodega`
  ADD CONSTRAINT `fk_TBL_DetalleInventarioBodega_TBL_EncaInventarioBodega1` FOREIGN KEY (`FK_Cod_Enca`) REFERENCES `tbl_encainventariobodega` (`PK_Cod_Enca`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_TBL_DetalleInventarioBodega_TBL_Sede1` FOREIGN KEY (`FK_id_Sede`) REFERENCES `tbl_sede` (`PK_id_Sede`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_TBL_InventarioBodega_TBL_Producto1` FOREIGN KEY (`FK_Codigo_Producto`) REFERENCES `tbl_producto` (`PK_Codigo_Producto`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_detalle_doc_inventario`
--
ALTER TABLE `tbl_detalle_doc_inventario`
  ADD CONSTRAINT `fk_TBL_Detalle_Doc_Inventario_TBL_DetalleInventarioBodega1` FOREIGN KEY (`FK_DetalleInventarioBodega`) REFERENCES `tbl_detalleinventariobodega` (`PK_DetalleInventarioBodega`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_TBL_Doc_Inventario_TBL_Enc_Doc_Inventario1` FOREIGN KEY (`FK_Enc_Doc_Inventario`) REFERENCES `tbl_enc_doc_inventario` (`PK_Enc_Doc_Inventario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_TBL_Doc_Inventario_TBL_Producto1` FOREIGN KEY (`FK_Codigo_Producto`) REFERENCES `tbl_producto` (`PK_Codigo_Producto`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_detalle_envio`
--
ALTER TABLE `tbl_detalle_envio`
  ADD CONSTRAINT `fk_TBL_Detalle_Envio_TBL_Envio_Encabezado1` FOREIGN KEY (`FK_Codigo_Encabezado`) REFERENCES `tbl_envio_encabezado` (`PK_Codigo_Encabezado_Envio`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_TBL_Detalle_Envio_TBL_Producto1` FOREIGN KEY (`FK_Codigo_Producto`) REFERENCES `tbl_producto` (`PK_Codigo_Producto`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_doc_auditoria`
--
ALTER TABLE `tbl_doc_auditoria`
  ADD CONSTRAINT `fk_TBL_Doc_Auditoria_TBL_Bodega1` FOREIGN KEY (`FK_Codigo_bodega`) REFERENCES `tbl_bodega` (`PK_Codigo_bodega`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_encainventariobodega`
--
ALTER TABLE `tbl_encainventariobodega`
  ADD CONSTRAINT `fk_TBL_EncaInventarioBodega_TBL_Bodega1` FOREIGN KEY (`FK_Codigo_bodega`) REFERENCES `tbl_bodega` (`PK_Codigo_bodega`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_enc_doc_inventario`
--
ALTER TABLE `tbl_enc_doc_inventario`
  ADD CONSTRAINT `fk_TBL_Enc_Doc_Inventario_TBL_Operaciones_Inv1` FOREIGN KEY (`FK_Opc_inventario`) REFERENCES `tbl_operaciones_inv` (`PK_Opc_inventario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_entrega_producto_historial`
--
ALTER TABLE `tbl_entrega_producto_historial`
  ADD CONSTRAINT `codigo_producto_historial_fk` FOREIGN KEY (`Codigo_Producto`) REFERENCES `tbl_producto` (`PK_Codigo_Producto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `ruta_detalle_historial_fk` FOREIGN KEY (`Ruta_detalle_correlativo`) REFERENCES `tbl_ruta_detalle` (`PK_ruta_detalle_correlativo`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_envio_encabezado`
--
ALTER TABLE `tbl_envio_encabezado`
  ADD CONSTRAINT `fk_TBL_Envio_Encabezado_TBL_Destino1` FOREIGN KEY (`FK_correlativo_destino`) REFERENCES `tbl_destino` (`PK_correlativo_destino`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_TBL_Envio_Encabezado_TBL_Sede1` FOREIGN KEY (`FK_id_Sede`) REFERENCES `tbl_sede` (`PK_id_Sede`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_TBL_Envio_Encabezado_TBL_Vehiculos1` FOREIGN KEY (`FK_id_Vehiculos`) REFERENCES `tbl_vehiculos` (`PK_id_Vehiculos`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_historico_producto`
--
ALTER TABLE `tbl_historico_producto`
  ADD CONSTRAINT `fk_Producto_Grupo_de_Productos10` FOREIGN KEY (`FK_GrupoProductos`) REFERENCES `tbl_grupo_de_productos` (`PK_Codigo_Grupo_de_Productos`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Producto_marca0` FOREIGN KEY (`FK_Marca`) REFERENCES `tbl_modelo` (`PK_id_modelo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_TBL_Historico_Producto_TBL_Respaldos1` FOREIGN KEY (`TBL_Respaldos_PK_codigo_respaldo`) REFERENCES `tbl_respaldos` (`PK_codigo_respaldo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_TBL_Producto_TBL_Tipo_Producto10` FOREIGN KEY (`FK_Tipo_Producto`) REFERENCES `tbl_tipo_producto` (`PK_Id_Tipo_Pro`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_TBL_Producto_UnidadDeMedidaBase10` FOREIGN KEY (`FK_UnidadDeMedida`) REFERENCES `tbl_unidaddemedidabase` (`PK_CodigoDeUnidadDeMedidaBase`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_marca`
--
ALTER TABLE `tbl_marca`
  ADD CONSTRAINT `FK_idmarca` FOREIGN KEY (`FK_Modelo`) REFERENCES `tbl_modelo` (`PK_id_modelo`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_muestra_auditoria`
--
ALTER TABLE `tbl_muestra_auditoria`
  ADD CONSTRAINT `fk_TBL_Muestra_Auditoria_TBL_Doc_Auditoria1` FOREIGN KEY (`PK_Id_Doc_Auditoria`) REFERENCES `tbl_doc_auditoria` (`PK_Id_Doc_Auditoria`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_TBL_Muestra_Auditoria_TBL_Producto1` FOREIGN KEY (`PK_Codigo_Producto`) REFERENCES `tbl_producto` (`PK_Codigo_Producto`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_ordendecompradetalle`
--
ALTER TABLE `tbl_ordendecompradetalle`
  ADD CONSTRAINT `fk_TBL_OrdenDeCompraDetalle_TBL_OrdenDeCompraEncabezado1` FOREIGN KEY (`FK_EncabezadoOrden`) REFERENCES `tbl_ordendecompraencabezado` (`PK_NumeroOrden`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_TBL_OrdenDeCompraDetalle_TBL_Producto1` FOREIGN KEY (`FK_Productos`) REFERENCES `tbl_producto` (`PK_Codigo_Producto`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_ordendedevoluciondetalle`
--
ALTER TABLE `tbl_ordendedevoluciondetalle`
  ADD CONSTRAINT `fk_TBL_OrdenDeCompraDetalle_TBL_OrdenDeCompraEncabezado10` FOREIGN KEY (`FK_EncabezadoOrden`) REFERENCES `tbl_ordendedevolucionencabezado` (`PK_NumeroOrden`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_TBL_OrdenDeDevolucionDetalle_TBL_Producto1` FOREIGN KEY (`FK_Producto`) REFERENCES `tbl_producto` (`PK_Codigo_Producto`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_producto`
--
ALTER TABLE `tbl_producto`
  ADD CONSTRAINT `fk_Producto_Grupo_de_Productos1` FOREIGN KEY (`FK_GrupoProductos`) REFERENCES `tbl_grupo_de_productos` (`PK_Codigo_Grupo_de_Productos`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_TBL_Producto_TBL_Tipo_Producto1` FOREIGN KEY (`FK_Tipo_Producto`) REFERENCES `tbl_tipo_producto` (`PK_Id_Tipo_Pro`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_TBL_Producto_UnidadDeMedidaBase1` FOREIGN KEY (`FK_UnidadDeMedida`) REFERENCES `tbl_unidaddemedidabase` (`PK_CodigoDeUnidadDeMedidaBase`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_ruta_detalle`
--
ALTER TABLE `tbl_ruta_detalle`
  ADD CONSTRAINT `fk_ruta_detalle_destino` FOREIGN KEY (`destino_id`) REFERENCES `tbl_destino` (`PK_correlativo_destino`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_ruta_detalle_encabezado` FOREIGN KEY (`id_encabezado`) REFERENCES `tbl_ruta_encabezado` (`PK_Correlativo_ruta`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_vehiculos`
--
ALTER TABLE `tbl_vehiculos`
  ADD CONSTRAINT `fk_TBL_Vehiculos_TBL_Marca1` FOREIGN KEY (`FK_Modelo`) REFERENCES `tbl_modelo` (`PK_id_modelo`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
