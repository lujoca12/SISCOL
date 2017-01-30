-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.0.90-community-nt


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema bdevenezer
--

CREATE DATABASE IF NOT EXISTS bdevenezer;
USE bdevenezer;

--
-- Definition of table `tbl_acceso`
--

DROP TABLE IF EXISTS `tbl_acceso`;
CREATE TABLE `tbl_acceso` (
  `id_Acceso` int(11) NOT NULL auto_increment,
  `nombre_Acceso` varchar(45) default NULL,
  `tbl_Roles_id_Rol` char(1) NOT NULL,
  PRIMARY KEY  (`id_Acceso`),
  KEY `fk_tbl_Acceso_tbl_Roles1` (`tbl_Roles_id_Rol`),
  CONSTRAINT `fk_tbl_Acceso_tbl_Roles1` FOREIGN KEY (`tbl_Roles_id_Rol`) REFERENCES `tbl_roles` (`id_Rol`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_acceso`
--

/*!40000 ALTER TABLE `tbl_acceso` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_acceso` ENABLE KEYS */;


--
-- Definition of table `tbl_banco_cheques`
--

DROP TABLE IF EXISTS `tbl_banco_cheques`;
CREATE TABLE `tbl_banco_cheques` (
  `numero_Cheque` int(11) NOT NULL,
  `id_Bco` int(11) NOT NULL,
  `concepto` varchar(60) default NULL,
  `fecha_Emision` date default NULL,
  `fecha_Vencimiento` date default NULL,
  `total_Cheque` float default NULL,
  PRIMARY KEY  (`numero_Cheque`),
  KEY `FK_banco_cheques_bancos` (`id_Bco`),
  CONSTRAINT `FK_banco_cheques_bancos` FOREIGN KEY (`id_Bco`) REFERENCES `tbl_bancos` (`id_Banco`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_banco_cheques`
--

/*!40000 ALTER TABLE `tbl_banco_cheques` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_banco_cheques` ENABLE KEYS */;


--
-- Definition of table `tbl_bancos`
--

DROP TABLE IF EXISTS `tbl_bancos`;
CREATE TABLE `tbl_bancos` (
  `id_Banco` int(11) NOT NULL auto_increment,
  `numero_Cuenta` varchar(15) default NULL,
  `propietario_Cuenta` varchar(60) default NULL,
  PRIMARY KEY  (`id_Banco`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_bancos`
--

/*!40000 ALTER TABLE `tbl_bancos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_bancos` ENABLE KEYS */;


--
-- Definition of table `tbl_bodega`
--

DROP TABLE IF EXISTS `tbl_bodega`;
CREATE TABLE `tbl_bodega` (
  `id_Bodega` int(11) NOT NULL auto_increment,
  `nombreBodega` varchar(80) default NULL,
  `id_Periodo` int(11) NOT NULL,
  PRIMARY KEY  (`id_Bodega`),
  KEY `FK_bodega_periodo` (`id_Periodo`),
  CONSTRAINT `FK_bodega_periodo` FOREIGN KEY (`id_Periodo`) REFERENCES `tbl_periodo` (`id_Periodo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_bodega`
--

/*!40000 ALTER TABLE `tbl_bodega` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_bodega` ENABLE KEYS */;


--
-- Definition of table `tbl_bodega_productos`
--

DROP TABLE IF EXISTS `tbl_bodega_productos`;
CREATE TABLE `tbl_bodega_productos` (
  `id_Bodega_Product` int(11) NOT NULL auto_increment,
  `id_Bodega` int(11) NOT NULL,
  `codigo_Producto` varchar(15) NOT NULL,
  `stock` float default NULL,
  `stock_Minimo` float default NULL,
  `stock_Maximo` float default NULL,
  PRIMARY KEY  (`id_Bodega_Product`),
  KEY `FK_bodega_productos_bodega` (`id_Bodega`),
  KEY `FK_bodega_productos_productos` (`codigo_Producto`),
  CONSTRAINT `FK_bodega_productos_bodega` FOREIGN KEY (`id_Bodega`) REFERENCES `tbl_bodega` (`id_Bodega`),
  CONSTRAINT `FK_bodega_productos_productos` FOREIGN KEY (`codigo_Producto`) REFERENCES `tbl_productos` (`codigo_Producto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_bodega_productos`
--

/*!40000 ALTER TABLE `tbl_bodega_productos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_bodega_productos` ENABLE KEYS */;


--
-- Definition of table `tbl_ciudad`
--

DROP TABLE IF EXISTS `tbl_ciudad`;
CREATE TABLE `tbl_ciudad` (
  `id_Ciudad` int(11) NOT NULL auto_increment,
  `nombre_Ciudad` varchar(40) default NULL,
  `id_Pais` int(11) NOT NULL,
  PRIMARY KEY  (`id_Ciudad`),
  KEY `FK_ciudad_pais` (`id_Pais`),
  CONSTRAINT `FK_ciudad_pais` FOREIGN KEY (`id_Pais`) REFERENCES `tbl_pais` (`id_Pais`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_ciudad`
--

/*!40000 ALTER TABLE `tbl_ciudad` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_ciudad` ENABLE KEYS */;


--
-- Definition of table `tbl_clase_producto`
--

DROP TABLE IF EXISTS `tbl_clase_producto`;
CREATE TABLE `tbl_clase_producto` (
  `id_Clase_Product` int(11) NOT NULL auto_increment,
  `nombre_Clase_Prod` varchar(50) default NULL,
  `id_Tipo_Producto` int(11) NOT NULL,
  PRIMARY KEY  (`id_Clase_Product`),
  KEY `FK_clase_producto_tipo_producto` (`id_Tipo_Producto`),
  CONSTRAINT `FK_clase_producto_tipo_producto` FOREIGN KEY (`id_Tipo_Producto`) REFERENCES `tbl_tipo_producto` (`id_Tipo_Producto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_clase_producto`
--

/*!40000 ALTER TABLE `tbl_clase_producto` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_clase_producto` ENABLE KEYS */;


--
-- Definition of table `tbl_clientes`
--

DROP TABLE IF EXISTS `tbl_clientes`;
CREATE TABLE `tbl_clientes` (
  `cedula_Cliente` varchar(10) NOT NULL,
  `nombres_Cliente` varchar(40) default NULL,
  `apellidos_Cliente` varchar(60) default NULL,
  `direccion` varchar(80) default NULL,
  `telefono` varchar(10) default NULL,
  `email` varchar(40) default NULL,
  PRIMARY KEY  (`cedula_Cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_clientes`
--

/*!40000 ALTER TABLE `tbl_clientes` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_clientes` ENABLE KEYS */;


--
-- Definition of table `tbl_compra_efectivo`
--

DROP TABLE IF EXISTS `tbl_compra_efectivo`;
CREATE TABLE `tbl_compra_efectivo` (
  `id_Compra_Efectivo` int(11) NOT NULL auto_increment,
  `id_Compra` int(11) NOT NULL,
  `total_Compra` float default NULL,
  `fecha_Compra` date default NULL,
  `responsable` varchar(40) default NULL,
  PRIMARY KEY  (`id_Compra_Efectivo`),
  KEY `FK_compra_efectivo_compras` (`id_Compra`),
  CONSTRAINT `FK_compra_efectivo_compras` FOREIGN KEY (`id_Compra`) REFERENCES `tbl_compras` (`id_Compra`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_compra_efectivo`
--

/*!40000 ALTER TABLE `tbl_compra_efectivo` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_compra_efectivo` ENABLE KEYS */;


--
-- Definition of table `tbl_compras`
--

DROP TABLE IF EXISTS `tbl_compras`;
CREATE TABLE `tbl_compras` (
  `id_Compra` int(11) NOT NULL auto_increment,
  `fecha_Compra` date default NULL,
  `numero_Compra` varchar(15) NOT NULL,
  `concepto` varchar(100) default NULL,
  `documento_Tipo` varchar(30) default NULL,
  `codigo_Producto` varchar(15) default NULL,
  `id_Proveedor` int(11) NOT NULL,
  `id_Producto_Ice` int(11) NOT NULL,
  PRIMARY KEY  (`id_Compra`),
  KEY `FK_compras_proveedores` (`id_Proveedor`),
  KEY `FK_compras_productos` (`codigo_Producto`),
  KEY `FK_compras_prod_ice` (`id_Producto_Ice`),
  CONSTRAINT `FK_compras_productos` FOREIGN KEY (`codigo_Producto`) REFERENCES `tbl_productos` (`codigo_Producto`),
  CONSTRAINT `FK_compras_prod_ice` FOREIGN KEY (`id_Producto_Ice`) REFERENCES `tbl_prod_ice` (`id_prod_ICE`),
  CONSTRAINT `FK_compras_proveedores` FOREIGN KEY (`id_Proveedor`) REFERENCES `tbl_proveedores` (`id_Proveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_compras`
--

/*!40000 ALTER TABLE `tbl_compras` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_compras` ENABLE KEYS */;


--
-- Definition of table `tbl_cxc`
--

DROP TABLE IF EXISTS `tbl_cxc`;
CREATE TABLE `tbl_cxc` (
  `id_CxC` int(11) NOT NULL auto_increment,
  `id_Factura` int(11) NOT NULL,
  `fecha_Emision` date default NULL,
  `abono` float default NULL,
  `fecha_Vencimiento` date default NULL,
  `total_CxC` float default NULL,
  `id_Recaudador` int(11) NOT NULL,
  PRIMARY KEY  (`id_CxC`),
  KEY `FK_cxc_factura` (`id_Factura`),
  CONSTRAINT `FK_cxc_factura` FOREIGN KEY (`id_Factura`) REFERENCES `tbl_factura` (`id_Factura`),
  CONSTRAINT `FK_tbl_cxc_tbl_recaudadores_id_Recaudador` FOREIGN KEY (`id_CxC`) REFERENCES `tbl_recaudadores` (`id_Recaudador`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_cxc`
--

/*!40000 ALTER TABLE `tbl_cxc` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_cxc` ENABLE KEYS */;


--
-- Definition of table `tbl_cxp`
--

DROP TABLE IF EXISTS `tbl_cxp`;
CREATE TABLE `tbl_cxp` (
  `id_CxP` int(11) NOT NULL auto_increment,
  `id_Compra` int(11) NOT NULL,
  `fecha_Emision` date default NULL,
  `abono` float default NULL,
  `fecha_Vencimiento` date default NULL,
  `total_CxP` float default NULL,
  `id_Numero_Cheque` int(11) NOT NULL,
  PRIMARY KEY  (`id_CxP`),
  KEY `FK_cxp_compras` (`id_Compra`),
  KEY `FK_cxp_banco_cheques` (`id_Numero_Cheque`),
  CONSTRAINT `FK_cxp_banco_cheques` FOREIGN KEY (`id_Numero_Cheque`) REFERENCES `tbl_banco_cheques` (`numero_Cheque`),
  CONSTRAINT `FK_cxp_compras` FOREIGN KEY (`id_Compra`) REFERENCES `tbl_compras` (`id_Compra`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_cxp`
--

/*!40000 ALTER TABLE `tbl_cxp` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_cxp` ENABLE KEYS */;


--
-- Definition of table `tbl_detalle_factura`
--

DROP TABLE IF EXISTS `tbl_detalle_factura`;
CREATE TABLE `tbl_detalle_factura` (
  `id_Detalle_Factura` int(11) NOT NULL auto_increment,
  `cantidad` float default NULL,
  `precio` float default NULL,
  `descuento` float default NULL,
  `total` float default NULL,
  `id_Factura` int(11) NOT NULL,
  `id_Codigo_Prod` varchar(15) NOT NULL,
  PRIMARY KEY  (`id_Detalle_Factura`),
  KEY `FK_detalle_factura_factura` (`id_Factura`),
  KEY `FK_detalle_factura_productos` (`id_Codigo_Prod`),
  CONSTRAINT `FK_detalle_factura_factura` FOREIGN KEY (`id_Factura`) REFERENCES `tbl_factura` (`id_Factura`),
  CONSTRAINT `FK_detalle_factura_productos` FOREIGN KEY (`id_Codigo_Prod`) REFERENCES `tbl_productos` (`codigo_Producto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_detalle_factura`
--

/*!40000 ALTER TABLE `tbl_detalle_factura` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_detalle_factura` ENABLE KEYS */;


--
-- Definition of table `tbl_empresa`
--

DROP TABLE IF EXISTS `tbl_empresa`;
CREATE TABLE `tbl_empresa` (
  `id_Empresa` int(11) NOT NULL auto_increment,
  `nombreEmpresa` varchar(80) default NULL,
  `rucEmpresa` varchar(13) default NULL,
  `direccion` varchar(80) default NULL,
  `telefono` varchar(10) default NULL,
  `id_Pais` int(11) NOT NULL,
  `logoEmpresa` float default NULL,
  PRIMARY KEY  (`id_Empresa`),
  KEY `tbl_empresa_VR1` (`id_Pais`),
  CONSTRAINT `tbl_empresa_VR1` FOREIGN KEY (`id_Pais`) REFERENCES `tbl_pais` (`id_Pais`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_empresa`
--

/*!40000 ALTER TABLE `tbl_empresa` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_empresa` ENABLE KEYS */;


--
-- Definition of table `tbl_fact_efectivo`
--

DROP TABLE IF EXISTS `tbl_fact_efectivo`;
CREATE TABLE `tbl_fact_efectivo` (
  `id_Fact_Efect` int(11) NOT NULL auto_increment,
  `id_Factura` int(11) NOT NULL,
  `total_Factura` float default NULL,
  `fecha_Factura` date default NULL,
  PRIMARY KEY  (`id_Fact_Efect`),
  KEY `FK_fact_efectivo_factura` (`id_Factura`),
  CONSTRAINT `FK_fact_efectivo_factura` FOREIGN KEY (`id_Factura`) REFERENCES `tbl_factura` (`id_Factura`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_fact_efectivo`
--

/*!40000 ALTER TABLE `tbl_fact_efectivo` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_fact_efectivo` ENABLE KEYS */;


--
-- Definition of table `tbl_factura`
--

DROP TABLE IF EXISTS `tbl_factura`;
CREATE TABLE `tbl_factura` (
  `id_Factura` int(11) NOT NULL auto_increment,
  `fechaEmision` date default NULL,
  `nota` varchar(80) default NULL,
  `cedula_Vendedor` varchar(10) NOT NULL,
  `cedula_Cliente` varchar(10) NOT NULL,
  PRIMARY KEY  (`id_Factura`),
  KEY `FK_factural_vendedores` (`cedula_Vendedor`),
  KEY `FK_factura_clientes` (`cedula_Cliente`),
  CONSTRAINT `FK_factural_vendedores` FOREIGN KEY (`cedula_Vendedor`) REFERENCES `tbl_vendedores` (`cedula`),
  CONSTRAINT `FK_factura_clientes` FOREIGN KEY (`cedula_Cliente`) REFERENCES `tbl_clientes` (`cedula_Cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_factura`
--

/*!40000 ALTER TABLE `tbl_factura` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_factura` ENABLE KEYS */;


--
-- Definition of table `tbl_familia`
--

DROP TABLE IF EXISTS `tbl_familia`;
CREATE TABLE `tbl_familia` (
  `id_Familia` int(11) NOT NULL auto_increment,
  `nombre_Familia` varchar(40) default NULL,
  `codigo_Producto` varchar(15) default NULL,
  PRIMARY KEY  (`id_Familia`),
  KEY `FK_familia_productos` (`codigo_Producto`),
  CONSTRAINT `FK_familia_productos` FOREIGN KEY (`codigo_Producto`) REFERENCES `tbl_productos` (`codigo_Producto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_familia`
--

/*!40000 ALTER TABLE `tbl_familia` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_familia` ENABLE KEYS */;


--
-- Definition of table `tbl_funcion_acceso`
--

DROP TABLE IF EXISTS `tbl_funcion_acceso`;
CREATE TABLE `tbl_funcion_acceso` (
  `id_Funcion_Acceso` int(11) NOT NULL auto_increment,
  `nombre_Funcion_Acceso` varchar(60) default NULL,
  `tbl_Acceso_id_Acceso` int(11) NOT NULL,
  PRIMARY KEY  (`id_Funcion_Acceso`),
  KEY `fk_tbl_Funcion_Acceso_tbl_Acceso1` (`tbl_Acceso_id_Acceso`),
  CONSTRAINT `fk_tbl_Funcion_Acceso_tbl_Acceso1` FOREIGN KEY (`tbl_Acceso_id_Acceso`) REFERENCES `tbl_acceso` (`id_Acceso`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_funcion_acceso`
--

/*!40000 ALTER TABLE `tbl_funcion_acceso` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_funcion_acceso` ENABLE KEYS */;


--
-- Definition of table `tbl_pais`
--

DROP TABLE IF EXISTS `tbl_pais`;
CREATE TABLE `tbl_pais` (
  `id_Pais` int(11) NOT NULL auto_increment,
  `nombrePais` varchar(40) default NULL,
  PRIMARY KEY  (`id_Pais`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_pais`
--

/*!40000 ALTER TABLE `tbl_pais` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_pais` ENABLE KEYS */;


--
-- Definition of table `tbl_periodo`
--

DROP TABLE IF EXISTS `tbl_periodo`;
CREATE TABLE `tbl_periodo` (
  `id_Periodo` int(11) NOT NULL auto_increment,
  `aÃƒÂ±o` year(4) default NULL,
  `id_Empresa` int(11) NOT NULL,
  PRIMARY KEY  (`id_Periodo`),
  KEY `FK_periodo_empresa` (`id_Empresa`),
  CONSTRAINT `FK_periodo_empresa` FOREIGN KEY (`id_Empresa`) REFERENCES `tbl_empresa` (`id_Empresa`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_periodo`
--

/*!40000 ALTER TABLE `tbl_periodo` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_periodo` ENABLE KEYS */;


--
-- Definition of table `tbl_precios`
--

DROP TABLE IF EXISTS `tbl_precios`;
CREATE TABLE `tbl_precios` (
  `id_Precio` int(11) NOT NULL auto_increment,
  `codigo_Producto` varchar(15) NOT NULL,
  `costo` float default NULL,
  `fecha_Precio` date default NULL,
  `fecha_Caducidad` date default NULL,
  `Pvp` float default NULL,
  `precio1` float default NULL,
  `precio2` float default NULL,
  `precio3` float default NULL,
  `precio4` float default NULL,
  `precio5` float default NULL,
  `volumen1` float default NULL,
  `volumen2` float default NULL,
  `volumen3` float default NULL,
  `volumen4` float default NULL,
  `volumen5` float default NULL,
  PRIMARY KEY  (`id_Precio`),
  KEY `FK_precios_productos` (`codigo_Producto`),
  CONSTRAINT `FK_precios_productos` FOREIGN KEY (`codigo_Producto`) REFERENCES `tbl_productos` (`codigo_Producto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_precios`
--

/*!40000 ALTER TABLE `tbl_precios` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_precios` ENABLE KEYS */;


--
-- Definition of table `tbl_prod_ice`
--

DROP TABLE IF EXISTS `tbl_prod_ice`;
CREATE TABLE `tbl_prod_ice` (
  `id_prod_ICE` int(11) NOT NULL auto_increment,
  `descripcion` varchar(60) default NULL,
  `porcentaje_ICE` float default NULL,
  PRIMARY KEY  (`id_prod_ICE`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_prod_ice`
--

/*!40000 ALTER TABLE `tbl_prod_ice` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_prod_ice` ENABLE KEYS */;


--
-- Definition of table `tbl_product_proveedores`
--

DROP TABLE IF EXISTS `tbl_product_proveedores`;
CREATE TABLE `tbl_product_proveedores` (
  `id_Prod_Proveed` int(11) NOT NULL auto_increment,
  `id_Proveedor` int(11) NOT NULL,
  `codigo_Producto` varchar(15) NOT NULL,
  PRIMARY KEY  (`id_Prod_Proveed`),
  KEY `FK_product_proveedores` (`id_Proveedor`),
  KEY `FK_product_proveedores_productos` (`codigo_Producto`),
  CONSTRAINT `FK_product_proveedores` FOREIGN KEY (`id_Proveedor`) REFERENCES `tbl_proveedores` (`id_Proveedor`),
  CONSTRAINT `FK_product_proveedores_productos` FOREIGN KEY (`codigo_Producto`) REFERENCES `tbl_productos` (`codigo_Producto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_product_proveedores`
--

/*!40000 ALTER TABLE `tbl_product_proveedores` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_product_proveedores` ENABLE KEYS */;


--
-- Definition of table `tbl_productos`
--

DROP TABLE IF EXISTS `tbl_productos`;
CREATE TABLE `tbl_productos` (
  `codigo_Producto` varchar(15) NOT NULL,
  `descripcion` varchar(80) default NULL,
  `detalle` varchar(80) default NULL,
  `iva` tinyint(1) default NULL,
  `id_X_Cajas` int(11) default NULL,
  `id_Clase_Producto` int(11) default NULL,
  `negar_Stock` tinyint(1) default NULL,
  `activo` tinyint(1) default NULL,
  PRIMARY KEY  (`codigo_Producto`),
  KEY `FK_tbl_productos_tbl_und_x_cajas_id_X_Cajas` (`id_X_Cajas`),
  KEY `FK_tbl_productos_tbl_clase_producto_id_Clase_Product` (`id_Clase_Producto`),
  CONSTRAINT `FK_tbl_productos_tbl_clase_producto_id_Clase_Product` FOREIGN KEY (`id_Clase_Producto`) REFERENCES `tbl_clase_producto` (`id_Clase_Product`),
  CONSTRAINT `FK_tbl_productos_tbl_und_x_cajas_id_X_Cajas` FOREIGN KEY (`id_X_Cajas`) REFERENCES `tbl_und_x_cajas` (`id_X_Cajas`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_productos`
--

/*!40000 ALTER TABLE `tbl_productos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_productos` ENABLE KEYS */;


--
-- Definition of table `tbl_proveedores`
--

DROP TABLE IF EXISTS `tbl_proveedores`;
CREATE TABLE `tbl_proveedores` (
  `id_Proveedor` int(11) NOT NULL auto_increment,
  `rucProveedor` int(13) default NULL,
  `nombreProveed` varchar(40) default NULL,
  `apellidoProveed` varchar(60) default NULL,
  `telefono` varchar(10) default NULL,
  `direccion` varchar(80) default NULL,
  `email` varchar(40) default NULL,
  `serieComprob` int(6) default NULL,
  `desdeFactura` int(9) default NULL,
  `hastaFactura` int(9) default NULL,
  `autorizacion` int(10) default NULL,
  `fechaEmision` date default NULL,
  `fechaCaducidad` date default NULL,
  PRIMARY KEY  (`id_Proveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_proveedores`
--

/*!40000 ALTER TABLE `tbl_proveedores` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_proveedores` ENABLE KEYS */;


--
-- Definition of table `tbl_recaudadores`
--

DROP TABLE IF EXISTS `tbl_recaudadores`;
CREATE TABLE `tbl_recaudadores` (
  `id_Recaudador` int(11) NOT NULL auto_increment,
  `cedulaRecaudador` varchar(10) default NULL,
  `nombreRecaudador` varchar(40) default NULL,
  `apellidoRecaudad` varchar(60) default NULL,
  PRIMARY KEY  (`id_Recaudador`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_recaudadores`
--

/*!40000 ALTER TABLE `tbl_recaudadores` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_recaudadores` ENABLE KEYS */;


--
-- Definition of table `tbl_retencion_codigo`
--

DROP TABLE IF EXISTS `tbl_retencion_codigo`;
CREATE TABLE `tbl_retencion_codigo` (
  `id_Retencion_Codigo` int(11) NOT NULL,
  `descripcion` varchar(150) default NULL,
  `porcent_Retener` int(3) default NULL,
  PRIMARY KEY  (`id_Retencion_Codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_retencion_codigo`
--

/*!40000 ALTER TABLE `tbl_retencion_codigo` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_retencion_codigo` ENABLE KEYS */;


--
-- Definition of table `tbl_retenciones`
--

DROP TABLE IF EXISTS `tbl_retenciones`;
CREATE TABLE `tbl_retenciones` (
  `id_Retencion` int(11) NOT NULL auto_increment,
  `id_Proveedor` int(11) NOT NULL,
  `total_Factura` float default NULL,
  `valor_S_Iva` float default NULL,
  `valor_N_Iva` float default NULL,
  `serie_Comprob_Retenc` varchar(15) default NULL,
  `fecha_Emision` date default NULL,
  `autorizacion` varchar(10) default NULL,
  `id_Retencion_Codigo` int(11) NOT NULL,
  PRIMARY KEY  (`id_Retencion`),
  KEY `FK_retenciones_proveedores` (`id_Proveedor`),
  KEY `FK_retenciones_retencion_codigo` (`id_Retencion_Codigo`),
  CONSTRAINT `FK_retenciones_proveedores` FOREIGN KEY (`id_Proveedor`) REFERENCES `tbl_proveedores` (`id_Proveedor`),
  CONSTRAINT `FK_retenciones_retencion_codigo` FOREIGN KEY (`id_Retencion_Codigo`) REFERENCES `tbl_retencion_codigo` (`id_Retencion_Codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_retenciones`
--

/*!40000 ALTER TABLE `tbl_retenciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_retenciones` ENABLE KEYS */;


--
-- Definition of table `tbl_roles`
--

DROP TABLE IF EXISTS `tbl_roles`;
CREATE TABLE `tbl_roles` (
  `id_Rol` char(1) NOT NULL,
  `nombre_Rol` varchar(25) default NULL,
  PRIMARY KEY  (`id_Rol`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_roles`
--

/*!40000 ALTER TABLE `tbl_roles` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_roles` ENABLE KEYS */;


--
-- Definition of table `tbl_tipo_producto`
--

DROP TABLE IF EXISTS `tbl_tipo_producto`;
CREATE TABLE `tbl_tipo_producto` (
  `id_Tipo_Producto` int(11) NOT NULL auto_increment,
  `nombre_Tipo_Prod` varchar(50) default NULL,
  PRIMARY KEY  (`id_Tipo_Producto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_tipo_producto`
--

/*!40000 ALTER TABLE `tbl_tipo_producto` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_tipo_producto` ENABLE KEYS */;


--
-- Definition of table `tbl_und_x_cajas`
--

DROP TABLE IF EXISTS `tbl_und_x_cajas`;
CREATE TABLE `tbl_und_x_cajas` (
  `id_X_Cajas` int(11) NOT NULL auto_increment,
  `detalle_Unds` varchar(40) default NULL,
  `cantid_Caja` int(11) default NULL,
  PRIMARY KEY  (`id_X_Cajas`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_und_x_cajas`
--

/*!40000 ALTER TABLE `tbl_und_x_cajas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_und_x_cajas` ENABLE KEYS */;


--
-- Definition of table `tbl_usuarios`
--

DROP TABLE IF EXISTS `tbl_usuarios`;
CREATE TABLE `tbl_usuarios` (
  `id_Usuario` int(11) NOT NULL auto_increment,
  `nombre_Usuario` varchar(25) default NULL,
  `clave_Usuario` varchar(25) default NULL,
  `tbl_Roles_id_Rol` char(1) NOT NULL,
  `nombres` varchar(45) NOT NULL,
  `apellidos` varchar(60) NOT NULL,
  `direccion` varchar(80) NOT NULL,
  `telefono` char(10) NOT NULL,
  PRIMARY KEY  (`id_Usuario`),
  KEY `fk_tbl_usuarios_tbl_Roles1` (`tbl_Roles_id_Rol`),
  CONSTRAINT `fk_tbl_usuarios_tbl_Roles1` FOREIGN KEY (`tbl_Roles_id_Rol`) REFERENCES `tbl_roles` (`id_Rol`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_usuarios`
--

/*!40000 ALTER TABLE `tbl_usuarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_usuarios` ENABLE KEYS */;


--
-- Definition of table `tbl_vendedores`
--

DROP TABLE IF EXISTS `tbl_vendedores`;
CREATE TABLE `tbl_vendedores` (
  `cedula` varchar(10) NOT NULL,
  `nombresVendedor` varchar(40) default NULL,
  `apellidosVended` varchar(60) default NULL,
  `direccion` varchar(80) default NULL,
  `telefono` varchar(10) default NULL,
  `email` varchar(40) default NULL,
  PRIMARY KEY  (`cedula`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_vendedores`
--

/*!40000 ALTER TABLE `tbl_vendedores` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_vendedores` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
