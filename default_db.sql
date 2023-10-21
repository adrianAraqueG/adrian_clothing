-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 21-10-2023 a las 05:01:01
-- Versión del servidor: 10.4.28-MariaDB
-- Versión de PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `ropas`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cargos`
--

CREATE TABLE `cargos` (
  `Id` int(11) NOT NULL,
  `Descripcion` longtext DEFAULT NULL,
  `SueldoBase` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `cargos`
--

INSERT INTO `cargos` (`Id`, `Descripcion`, `SueldoBase`) VALUES
(1, 'CEO', 0),
(2, 'CEO', 1200000);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `Id` int(11) NOT NULL,
  `Nombre` longtext DEFAULT NULL,
  `FechaRegistro` datetime(6) NOT NULL,
  `IdTipoPersona` int(11) NOT NULL,
  `IdMunicipio` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`Id`, `Nombre`, `FechaRegistro`, `IdTipoPersona`, `IdMunicipio`) VALUES
(1, 'Andrés', '2023-10-03 20:52:49.000000', 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `colores`
--

CREATE TABLE `colores` (
  `Id` int(11) NOT NULL,
  `Descripcion` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `departamento`
--

CREATE TABLE `departamento` (
  `Id` int(11) NOT NULL,
  `Nombre` longtext DEFAULT NULL,
  `IdPais` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `departamento`
--

INSERT INTO `departamento` (`Id`, `Nombre`, `IdPais`) VALUES
(2, 'Santander', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detallesorden`
--

CREATE TABLE `detallesorden` (
  `Id` int(11) NOT NULL,
  `CantidadProducir` int(11) NOT NULL,
  `CantidadProducida` int(11) NOT NULL,
  `IdOrden` int(11) NOT NULL,
  `IdPrenda` int(11) NOT NULL,
  `IdColor` int(11) NOT NULL,
  `IdEstado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detallesventa`
--

CREATE TABLE `detallesventa` (
  `Id` int(11) NOT NULL,
  `Cantidad` int(11) NOT NULL,
  `ValorUnitario` double NOT NULL,
  `IdVenta` int(11) NOT NULL,
  `IdInventario` int(11) NOT NULL,
  `IdTalla` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleados`
--

CREATE TABLE `empleados` (
  `Id` int(11) NOT NULL,
  `Nombre` longtext DEFAULT NULL,
  `FechaIngreso` datetime(6) NOT NULL,
  `IdCargo` int(11) NOT NULL,
  `IdMunicipio` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `empleados`
--

INSERT INTO `empleados` (`Id`, `Nombre`, `FechaIngreso`, `IdCargo`, `IdMunicipio`) VALUES
(1, 'Juan Carlos Bodoque', '2023-10-03 20:57:36.000000', 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empresas`
--

CREATE TABLE `empresas` (
  `Id` int(11) NOT NULL,
  `NitEmpresa` longtext DEFAULT NULL,
  `RazonSocial` longtext DEFAULT NULL,
  `RepresentanteLegal` longtext DEFAULT NULL,
  `FechaCreacion` longtext DEFAULT NULL,
  `IdMunicipio` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estados`
--

CREATE TABLE `estados` (
  `Id` int(11) NOT NULL,
  `Descripción` longtext DEFAULT NULL,
  `IdTipoEstado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `estados`
--

INSERT INTO `estados` (`Id`, `Descripción`, `IdTipoEstado`) VALUES
(1, 'En proceso', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `formaspago`
--

CREATE TABLE `formaspago` (
  `Id` int(11) NOT NULL,
  `Descripcion` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `generos`
--

CREATE TABLE `generos` (
  `Id` int(11) NOT NULL,
  `Descripcion` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `insumoprenda`
--

CREATE TABLE `insumoprenda` (
  `IdInsumo` int(11) NOT NULL,
  `IdPrenda` int(11) NOT NULL,
  `Cantidad` int(11) NOT NULL,
  `Id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `insumoproveedor`
--

CREATE TABLE `insumoproveedor` (
  `IdInsumo` int(11) NOT NULL,
  `IdProveedor` int(11) NOT NULL,
  `Id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `insumos`
--

CREATE TABLE `insumos` (
  `Id` int(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `ValorUnitario` double NOT NULL,
  `StockMin` double NOT NULL,
  `StockMax` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inventarios`
--

CREATE TABLE `inventarios` (
  `Id` int(11) NOT NULL,
  `CodInventario` longtext DEFAULT NULL,
  `ValorVentaCop` double NOT NULL,
  `ValorVentaUsd` double NOT NULL,
  `IdPrenda` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inventariotalla`
--

CREATE TABLE `inventariotalla` (
  `IdInventario` int(11) NOT NULL,
  `IdTalla` int(11) NOT NULL,
  `Cantidad` int(11) NOT NULL,
  `Id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `municipios`
--

CREATE TABLE `municipios` (
  `Id` int(11) NOT NULL,
  `Nombre` longtext DEFAULT NULL,
  `IdDepartamento` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `municipios`
--

INSERT INTO `municipios` (`Id`, `Nombre`, `IdDepartamento`) VALUES
(1, 'Bucarmanga', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ordenes`
--

CREATE TABLE `ordenes` (
  `Id` int(11) NOT NULL,
  `Fecha` datetime(6) NOT NULL,
  `IdEmpleado` int(11) NOT NULL,
  `IdCliente` int(11) NOT NULL,
  `IdEstado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `ordenes`
--

INSERT INTO `ordenes` (`Id`, `Fecha`, `IdEmpleado`, `IdCliente`, `IdEstado`) VALUES
(1, '2023-10-19 20:58:22.000000', 1, 1, 1),
(2, '2024-10-19 20:58:22.000000', 1, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paises`
--

CREATE TABLE `paises` (
  `Id` int(11) NOT NULL,
  `Nombre` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `paises`
--

INSERT INTO `paises` (`Id`, `Nombre`) VALUES
(1, 'Colombia');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `prendas`
--

CREATE TABLE `prendas` (
  `Id` int(11) NOT NULL,
  `Nombre` longtext DEFAULT NULL,
  `ValorUnitarioCop` int(11) NOT NULL,
  `ValorUnitarioUsd` int(11) NOT NULL,
  `IdEstado` int(11) NOT NULL,
  `IdTipoProteccion` int(11) NOT NULL,
  `IdGenero` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedores`
--

CREATE TABLE `proveedores` (
  `Id` int(11) NOT NULL,
  `NitProveedor` longtext NOT NULL,
  `Nombre` longtext NOT NULL,
  `IdMunicipio` int(11) NOT NULL,
  `IdTipoPersona` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `refreshtoken`
--

CREATE TABLE `refreshtoken` (
  `Id` int(11) NOT NULL,
  `IdUsuario` int(11) NOT NULL,
  `Token` longtext DEFAULT NULL,
  `FechaExpiracion` datetime(6) NOT NULL,
  `Created` datetime(6) NOT NULL,
  `Revoked` datetime(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `refreshtoken`
--

INSERT INTO `refreshtoken` (`Id`, `IdUsuario`, `Token`, `FechaExpiracion`, `Created`, `Revoked`) VALUES
(1, 1, 'xHmCcR1qFKIzS5jBsD80SWOSb9Xlu+/ziJNUPZMHKQs=', '2023-10-21 01:22:09.826781', '2023-10-21 01:19:09.826824', NULL),
(2, 1, 'TA0vOjRXORkmHXmHtFAAxJwkgS3e/YhOWC1IaS3PFK0=', '2023-10-21 02:58:24.624739', '2023-10-21 02:55:24.624777', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `roles`
--

CREATE TABLE `roles` (
  `Id` int(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `roles`
--

INSERT INTO `roles` (`Id`, `Nombre`) VALUES
(1, 'WithoutRol');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tallas`
--

CREATE TABLE `tallas` (
  `Id` int(11) NOT NULL,
  `Descripcion` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipoestado`
--

CREATE TABLE `tipoestado` (
  `Id` int(11) NOT NULL,
  `Descripcion` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `tipoestado`
--

INSERT INTO `tipoestado` (`Id`, `Descripcion`) VALUES
(1, 'Activo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipopersona`
--

CREATE TABLE `tipopersona` (
  `Id` int(11) NOT NULL,
  `Nombre` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `tipopersona`
--

INSERT INTO `tipopersona` (`Id`, `Nombre`) VALUES
(1, 'Natural');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipoproteccion`
--

CREATE TABLE `tipoproteccion` (
  `Id` int(11) NOT NULL,
  `Descripcion` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuariorol`
--

CREATE TABLE `usuariorol` (
  `IdUsuario` int(11) NOT NULL,
  `IdRol` int(11) NOT NULL,
  `Id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuariorol`
--

INSERT INTO `usuariorol` (`IdUsuario`, `IdRol`, `Id`) VALUES
(1, 1, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `Id` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `DNI` varchar(15) NOT NULL,
  `email` varchar(100) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`Id`, `Username`, `DNI`, `email`, `password`) VALUES
(1, 'admin', '1118528058', 'admin@admin.com', 'AQAAAAIAAYagAAAAEM07ygMj596C66x7o8/LVQ0sO3fpjC8sWHzUZqd9P2I2VYmYqeLdLTqoVwG8Qbxjhw==');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

CREATE TABLE `ventas` (
  `Id` int(11) NOT NULL,
  `Fecha` datetime(6) NOT NULL,
  `IdEmpleado` int(11) NOT NULL,
  `IdCliente` int(11) NOT NULL,
  `IdFormaPago` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20231020234846_InitialMigration', '7.0.10');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cargos`
--
ALTER TABLE `cargos`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Clientes_IdMunicipio` (`IdMunicipio`),
  ADD KEY `IX_Clientes_IdTipoPersona` (`IdTipoPersona`);

--
-- Indices de la tabla `colores`
--
ALTER TABLE `colores`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `departamento`
--
ALTER TABLE `departamento`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Departamento_IdPais` (`IdPais`);

--
-- Indices de la tabla `detallesorden`
--
ALTER TABLE `detallesorden`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_DetallesOrden_IdColor` (`IdColor`),
  ADD KEY `IX_DetallesOrden_IdEstado` (`IdEstado`),
  ADD KEY `IX_DetallesOrden_IdOrden` (`IdOrden`),
  ADD KEY `IX_DetallesOrden_IdPrenda` (`IdPrenda`);

--
-- Indices de la tabla `detallesventa`
--
ALTER TABLE `detallesventa`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_DetallesVenta_IdInventario` (`IdInventario`),
  ADD KEY `IX_DetallesVenta_IdTalla` (`IdTalla`),
  ADD KEY `IX_DetallesVenta_IdVenta` (`IdVenta`);

--
-- Indices de la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Empleados_IdCargo` (`IdCargo`),
  ADD KEY `IX_Empleados_IdMunicipio` (`IdMunicipio`);

--
-- Indices de la tabla `empresas`
--
ALTER TABLE `empresas`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Empresas_IdMunicipio` (`IdMunicipio`);

--
-- Indices de la tabla `estados`
--
ALTER TABLE `estados`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Estados_IdTipoEstado` (`IdTipoEstado`);

--
-- Indices de la tabla `formaspago`
--
ALTER TABLE `formaspago`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `generos`
--
ALTER TABLE `generos`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `insumoprenda`
--
ALTER TABLE `insumoprenda`
  ADD PRIMARY KEY (`IdInsumo`,`IdPrenda`),
  ADD KEY `IX_InsumoPrenda_IdPrenda` (`IdPrenda`);

--
-- Indices de la tabla `insumoproveedor`
--
ALTER TABLE `insumoproveedor`
  ADD PRIMARY KEY (`IdInsumo`,`IdProveedor`),
  ADD KEY `IX_InsumoProveedor_IdProveedor` (`IdProveedor`);

--
-- Indices de la tabla `insumos`
--
ALTER TABLE `insumos`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `inventarios`
--
ALTER TABLE `inventarios`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Inventarios_IdPrenda` (`IdPrenda`);

--
-- Indices de la tabla `inventariotalla`
--
ALTER TABLE `inventariotalla`
  ADD PRIMARY KEY (`IdTalla`,`IdInventario`),
  ADD KEY `IX_InventarioTalla_IdInventario` (`IdInventario`);

--
-- Indices de la tabla `municipios`
--
ALTER TABLE `municipios`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Municipios_IdDepartamento` (`IdDepartamento`);

--
-- Indices de la tabla `ordenes`
--
ALTER TABLE `ordenes`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Ordenes_IdCliente` (`IdCliente`),
  ADD KEY `IX_Ordenes_IdEmpleado` (`IdEmpleado`),
  ADD KEY `IX_Ordenes_IdEstado` (`IdEstado`);

--
-- Indices de la tabla `paises`
--
ALTER TABLE `paises`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `prendas`
--
ALTER TABLE `prendas`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Prendas_IdEstado` (`IdEstado`),
  ADD KEY `IX_Prendas_IdGenero` (`IdGenero`),
  ADD KEY `IX_Prendas_IdTipoProteccion` (`IdTipoProteccion`);

--
-- Indices de la tabla `proveedores`
--
ALTER TABLE `proveedores`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Proveedores_IdMunicipio` (`IdMunicipio`),
  ADD KEY `IX_Proveedores_IdTipoPersona` (`IdTipoPersona`);

--
-- Indices de la tabla `refreshtoken`
--
ALTER TABLE `refreshtoken`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_RefreshToken_IdUsuario` (`IdUsuario`);

--
-- Indices de la tabla `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `IX_Roles_Nombre` (`Nombre`);

--
-- Indices de la tabla `tallas`
--
ALTER TABLE `tallas`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `tipoestado`
--
ALTER TABLE `tipoestado`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `tipopersona`
--
ALTER TABLE `tipopersona`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `tipoproteccion`
--
ALTER TABLE `tipoproteccion`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `usuariorol`
--
ALTER TABLE `usuariorol`
  ADD PRIMARY KEY (`IdUsuario`,`IdRol`),
  ADD KEY `IX_UsuarioRol_IdRol` (`IdRol`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `IX_Usuarios_DNI` (`DNI`);

--
-- Indices de la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Ventas_IdCliente` (`IdCliente`),
  ADD KEY `IX_Ventas_IdEmpleado` (`IdEmpleado`),
  ADD KEY `IX_Ventas_IdFormaPago` (`IdFormaPago`);

--
-- Indices de la tabla `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cargos`
--
ALTER TABLE `cargos`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `colores`
--
ALTER TABLE `colores`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `departamento`
--
ALTER TABLE `departamento`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `detallesorden`
--
ALTER TABLE `detallesorden`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `detallesventa`
--
ALTER TABLE `detallesventa`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `empleados`
--
ALTER TABLE `empleados`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `empresas`
--
ALTER TABLE `empresas`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `estados`
--
ALTER TABLE `estados`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `formaspago`
--
ALTER TABLE `formaspago`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `generos`
--
ALTER TABLE `generos`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `insumos`
--
ALTER TABLE `insumos`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `inventarios`
--
ALTER TABLE `inventarios`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `municipios`
--
ALTER TABLE `municipios`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `ordenes`
--
ALTER TABLE `ordenes`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `paises`
--
ALTER TABLE `paises`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `prendas`
--
ALTER TABLE `prendas`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `proveedores`
--
ALTER TABLE `proveedores`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `refreshtoken`
--
ALTER TABLE `refreshtoken`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `roles`
--
ALTER TABLE `roles`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `tallas`
--
ALTER TABLE `tallas`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tipoestado`
--
ALTER TABLE `tipoestado`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `tipopersona`
--
ALTER TABLE `tipopersona`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `tipoproteccion`
--
ALTER TABLE `tipoproteccion`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `ventas`
--
ALTER TABLE `ventas`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD CONSTRAINT `FK_Clientes_Municipios_IdMunicipio` FOREIGN KEY (`IdMunicipio`) REFERENCES `municipios` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Clientes_TipoPersona_IdTipoPersona` FOREIGN KEY (`IdTipoPersona`) REFERENCES `tipopersona` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `departamento`
--
ALTER TABLE `departamento`
  ADD CONSTRAINT `FK_Departamento_Paises_IdPais` FOREIGN KEY (`IdPais`) REFERENCES `paises` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `detallesorden`
--
ALTER TABLE `detallesorden`
  ADD CONSTRAINT `FK_DetallesOrden_Colores_IdColor` FOREIGN KEY (`IdColor`) REFERENCES `colores` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_DetallesOrden_Estados_IdEstado` FOREIGN KEY (`IdEstado`) REFERENCES `estados` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_DetallesOrden_Ordenes_IdOrden` FOREIGN KEY (`IdOrden`) REFERENCES `ordenes` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_DetallesOrden_Prendas_IdPrenda` FOREIGN KEY (`IdPrenda`) REFERENCES `prendas` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `detallesventa`
--
ALTER TABLE `detallesventa`
  ADD CONSTRAINT `FK_DetallesVenta_Inventarios_IdInventario` FOREIGN KEY (`IdInventario`) REFERENCES `inventarios` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_DetallesVenta_Tallas_IdTalla` FOREIGN KEY (`IdTalla`) REFERENCES `tallas` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_DetallesVenta_Ventas_IdVenta` FOREIGN KEY (`IdVenta`) REFERENCES `ventas` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD CONSTRAINT `FK_Empleados_Cargos_IdCargo` FOREIGN KEY (`IdCargo`) REFERENCES `cargos` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Empleados_Municipios_IdMunicipio` FOREIGN KEY (`IdMunicipio`) REFERENCES `municipios` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `empresas`
--
ALTER TABLE `empresas`
  ADD CONSTRAINT `FK_Empresas_Municipios_IdMunicipio` FOREIGN KEY (`IdMunicipio`) REFERENCES `municipios` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `estados`
--
ALTER TABLE `estados`
  ADD CONSTRAINT `FK_Estados_TipoEstado_IdTipoEstado` FOREIGN KEY (`IdTipoEstado`) REFERENCES `tipoestado` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `insumoprenda`
--
ALTER TABLE `insumoprenda`
  ADD CONSTRAINT `FK_InsumoPrenda_Insumos_IdPrenda` FOREIGN KEY (`IdPrenda`) REFERENCES `insumos` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_InsumoPrenda_Prendas_IdInsumo` FOREIGN KEY (`IdInsumo`) REFERENCES `prendas` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `insumoproveedor`
--
ALTER TABLE `insumoproveedor`
  ADD CONSTRAINT `FK_InsumoProveedor_Insumos_IdProveedor` FOREIGN KEY (`IdProveedor`) REFERENCES `insumos` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_InsumoProveedor_Proveedores_IdInsumo` FOREIGN KEY (`IdInsumo`) REFERENCES `proveedores` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `inventarios`
--
ALTER TABLE `inventarios`
  ADD CONSTRAINT `FK_Inventarios_Prendas_IdPrenda` FOREIGN KEY (`IdPrenda`) REFERENCES `prendas` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `inventariotalla`
--
ALTER TABLE `inventariotalla`
  ADD CONSTRAINT `FK_InventarioTalla_Inventarios_IdInventario` FOREIGN KEY (`IdInventario`) REFERENCES `inventarios` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_InventarioTalla_Tallas_IdInventario` FOREIGN KEY (`IdInventario`) REFERENCES `tallas` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `municipios`
--
ALTER TABLE `municipios`
  ADD CONSTRAINT `FK_Municipios_Departamento_IdDepartamento` FOREIGN KEY (`IdDepartamento`) REFERENCES `departamento` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `ordenes`
--
ALTER TABLE `ordenes`
  ADD CONSTRAINT `FK_Ordenes_Clientes_IdCliente` FOREIGN KEY (`IdCliente`) REFERENCES `clientes` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Ordenes_Empleados_IdEmpleado` FOREIGN KEY (`IdEmpleado`) REFERENCES `empleados` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Ordenes_Estados_IdEstado` FOREIGN KEY (`IdEstado`) REFERENCES `estados` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `prendas`
--
ALTER TABLE `prendas`
  ADD CONSTRAINT `FK_Prendas_Estados_IdEstado` FOREIGN KEY (`IdEstado`) REFERENCES `estados` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Prendas_Generos_IdGenero` FOREIGN KEY (`IdGenero`) REFERENCES `generos` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Prendas_TipoProteccion_IdTipoProteccion` FOREIGN KEY (`IdTipoProteccion`) REFERENCES `tipoproteccion` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `proveedores`
--
ALTER TABLE `proveedores`
  ADD CONSTRAINT `FK_Proveedores_Municipios_IdMunicipio` FOREIGN KEY (`IdMunicipio`) REFERENCES `municipios` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Proveedores_TipoPersona_IdTipoPersona` FOREIGN KEY (`IdTipoPersona`) REFERENCES `tipopersona` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `refreshtoken`
--
ALTER TABLE `refreshtoken`
  ADD CONSTRAINT `FK_RefreshToken_Usuarios_IdUsuario` FOREIGN KEY (`IdUsuario`) REFERENCES `usuarios` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `usuariorol`
--
ALTER TABLE `usuariorol`
  ADD CONSTRAINT `FK_UsuarioRol_Roles_IdRol` FOREIGN KEY (`IdRol`) REFERENCES `roles` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_UsuarioRol_Usuarios_IdUsuario` FOREIGN KEY (`IdUsuario`) REFERENCES `usuarios` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD CONSTRAINT `FK_Ventas_Clientes_IdCliente` FOREIGN KEY (`IdCliente`) REFERENCES `clientes` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Ventas_Empleados_IdEmpleado` FOREIGN KEY (`IdEmpleado`) REFERENCES `empleados` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Ventas_FormasPago_IdFormaPago` FOREIGN KEY (`IdFormaPago`) REFERENCES `formaspago` (`Id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
