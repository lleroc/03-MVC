-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost:3306
-- Tiempo de generación: 06-08-2024 a las 00:53:09
-- Versión del servidor: 5.7.24
-- Versión de PHP: 8.2.14
SET
    SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";

START TRANSACTION;

SET
    time_zone = "+00:00";

--
-- Base de datos: `cuarto`
--
-- --------------------------------------------------------
--
-- Estructura de tabla para la tabla `roles`
--
CREATE TABLE
    `roles` (
        `RolesId` int (11) NOT NULL,
        `Detalle` text NOT NULL
    ) ENGINE = InnoDB DEFAULT CHARSET = utf8;

-- --------------------------------------------------------
--
-- Estructura de tabla para la tabla `usuarios`
--
CREATE TABLE
    `usuarios` (
        `UsuarioId` int (11) NOT NULL,
        `Nombre` text NOT NULL,
        `Apellido` text NOT NULL,
        `NombreUsuario` text NOT NULL,
        `Contrasenia` text NOT NULL,
        `Estado` int (1) NOT NULL COMMENT 'Valroes \r\n1 => Activo\r\n0 => Inactivo',
        `Creado` datetime NOT NULL
    ) ENGINE = InnoDB DEFAULT CHARSET = utf8;

-- --------------------------------------------------------
--
-- Estructura de tabla para la tabla `usuarios_roles`
--
CREATE TABLE
    `usuarios_roles` (
        `usuarios_roles_id` int (11) NOT NULL,
        `usuarioId` int (11) NOT NULL,
        `rolesid` int (11) NOT NULL
    ) ENGINE = InnoDB DEFAULT CHARSET = utf8;

--
-- Índices para tablas volcadas
--
--
-- Indices de la tabla `roles`
--
ALTER TABLE `roles` ADD PRIMARY KEY (`RolesId`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios` ADD PRIMARY KEY (`UsuarioId`);

--
-- Indices de la tabla `usuarios_roles`
--
ALTER TABLE `usuarios_roles` ADD PRIMARY KEY (`usuarios_roles_id`),
ADD KEY `roles` (`rolesid`),
ADD KEY `usuarios` (`usuarioId`);

--
-- AUTO_INCREMENT de las tablas volcadas
--
--
-- AUTO_INCREMENT de la tabla `roles`
--
ALTER TABLE `roles` MODIFY `RolesId` int (11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios` MODIFY `UsuarioId` int (11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `usuarios_roles`
--
ALTER TABLE `usuarios_roles` MODIFY `usuarios_roles_id` int (11) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--
--
-- Filtros para la tabla `usuarios_roles`
--
ALTER TABLE `usuarios_roles` ADD CONSTRAINT `roles` FOREIGN KEY (`rolesid`) REFERENCES `roles` (`RolesId`),
ADD CONSTRAINT `usuarios` FOREIGN KEY (`usuarioId`) REFERENCES `usuarios` (`UsuarioId`);

COMMIT;