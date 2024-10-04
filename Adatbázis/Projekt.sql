CREATE TABLE `Vendeg` (
  `vendeg_id` integer PRIMARY KEY,
  `vendeg_v_nev` varchar(255),
  `vendeg_k_nev` varchar(255),
  `vendeg_tel` integer,
  `vendeg_mail` varchar(255),
  `vendeg_pontok` integer
);

CREATE TABLE `Dolgozók` (
  `dolgozo_id` integer PRIMARY KEY,
  `dolgozo_v_nev` varchar(255),
  `dolgozo_k_nev` varchar(255),
  `szolgaltatas_id` integer,
  `dolgozo_tel` integer,
  `dolgozo_mail` varchar(255)
);

CREATE TABLE `Szolgaltatas` (
  `szolgaltatas_id` integer PRIMARY KEY,
  `szolgaltatas_kategoria` varchar(255),
  `szolgaltatas_idotartam` integer,
  `szolgaltatas_ar` integer
);

CREATE TABLE `Foglalas` (
  `foglalas_id` integer PRIMARY KEY,
  `szolgaltatas_id` integer,
  `dolgozo_id` integer,
  `vendeg_id` integer,
  `foglalas_kezdes_idop` datetime,
  `foglalas_befejezes_idop` datetime
);

ALTER TABLE `Foglalas` ADD FOREIGN KEY (`szolgaltatas_id`) REFERENCES `Szolgaltatas` (`szolgaltatas_id`);

ALTER TABLE `Foglalas` ADD FOREIGN KEY (`dolgozo_id`) REFERENCES `Dolgozók` (`dolgozo_id`);

ALTER TABLE `Foglalas` ADD FOREIGN KEY (`vendeg_id`) REFERENCES `Vendeg` (`vendeg_id`);
