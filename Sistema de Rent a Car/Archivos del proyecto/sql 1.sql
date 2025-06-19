CREATE TABLE autos (
    id_autos  int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    marca_modelo_auto  varchar(255)
);

CREATE TABLE autos_alquilados (
    id_autos_alquilados   int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    nombre_cliente   varchar(255),
	fecha_inicio_alquiler  varchar(255),
	fecha_final_alquiler varchar(255),
	auto_seleccionado varchar(255),
	estado_alquiler varchar(255)
);