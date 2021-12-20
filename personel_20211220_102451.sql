--
-- PostgreSQL database dump
--

-- Dumped from database version 14.1
-- Dumped by pg_dump version 14.0

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: Test; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE "Test" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Turkish_Turkey.1254';


ALTER DATABASE "Test" OWNER TO postgres;

\connect "Test"

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: banka_odemesi; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.banka_odemesi (
    islem_id integer NOT NULL,
    fatura_id integer NOT NULL,
    toplam_ucret integer NOT NULL,
    banka character varying(32) NOT NULL
);


ALTER TABLE public.banka_odemesi OWNER TO postgres;

--
-- Name: banka_odemesi_banka_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.banka_odemesi ALTER COLUMN islem_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.banka_odemesi_banka_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: entry; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.entry (
    username character varying(32) NOT NULL,
    password character varying(32) NOT NULL
);


ALTER TABLE public.entry OWNER TO postgres;

--
-- Name: fatura; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.fatura (
    fatura_id integer NOT NULL,
    kargo_sirketi integer NOT NULL,
    sepet_id integer NOT NULL,
    banka_odemesi integer NOT NULL,
    musteri_id integer NOT NULL,
    active boolean NOT NULL
);


ALTER TABLE public.fatura OWNER TO postgres;

--
-- Name: fatura_banka_odemesi_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.fatura ALTER COLUMN banka_odemesi ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.fatura_banka_odemesi_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: fatura_fatura_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.fatura ALTER COLUMN fatura_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.fatura_fatura_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: fatura_sepet_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.fatura ALTER COLUMN sepet_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.fatura_sepet_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: geri_iade; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.geri_iade (
    geri_id integer NOT NULL,
    urun_id integer NOT NULL,
    fatura_id integer NOT NULL,
    personel_id integer,
    geri_sebep character varying(256)
);


ALTER TABLE public.geri_iade OWNER TO postgres;

--
-- Name: geri_iade_geri_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.geri_iade ALTER COLUMN geri_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.geri_iade_geri_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: iller; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.iller (
    il_id integer NOT NULL,
    il character varying(20) NOT NULL
);


ALTER TABLE public.iller OWNER TO postgres;

--
-- Name: kargo_sirketi; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.kargo_sirketi (
    kargo_id integer NOT NULL,
    kargo_ad character varying(20) NOT NULL,
    kargo_temsilcisi_adsoyad character varying(128),
    kargo_temsilcisi_tel character varying(18)
);


ALTER TABLE public.kargo_sirketi OWNER TO postgres;

--
-- Name: kargo_sirketi_kargo_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.kargo_sirketi ALTER COLUMN kargo_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.kargo_sirketi_kargo_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: marka; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.marka (
    marka_id integer NOT NULL,
    marka_adi character varying(20) NOT NULL,
    marka_ulkesi character varying(20)
);


ALTER TABLE public.marka OWNER TO postgres;

--
-- Name: marka_marka_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.marka ALTER COLUMN marka_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.marka_marka_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: musteriler; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.musteriler (
    musteri_id integer NOT NULL,
    musteri_adi character varying(32) NOT NULL,
    musteri_soyadi character varying NOT NULL,
    musteri_eleman_yakini integer,
    musteri_il_id integer NOT NULL
);


ALTER TABLE public.musteriler OWNER TO postgres;

--
-- Name: musteriler_musteri_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.musteriler ALTER COLUMN musteri_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.musteriler_musteri_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
    CYCLE
);


--
-- Name: per_calisma_saatleri; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.per_calisma_saatleri (
    personel_id integer NOT NULL,
    baslangic_saat integer NOT NULL,
    bitis_saat integer NOT NULL,
    vardiya_id integer NOT NULL
);


ALTER TABLE public.per_calisma_saatleri OWNER TO postgres;

--
-- Name: per_calisma_saatleri_vardiya_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.per_calisma_saatleri ALTER COLUMN vardiya_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.per_calisma_saatleri_vardiya_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: per_it; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.per_it (
    personel_id integer NOT NULL,
    personel_adi character varying(20) NOT NULL
);


ALTER TABLE public.per_it OWNER TO postgres;

--
-- Name: per_satis; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.per_satis (
    personel_id integer NOT NULL,
    personel_ad character(32) NOT NULL,
    bolge integer NOT NULL
);


ALTER TABLE public.per_satis OWNER TO postgres;

--
-- Name: per_yonetim; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.per_yonetim (
    personel_id integer NOT NULL,
    personel_adi character(32) NOT NULL
);


ALTER TABLE public.per_yonetim OWNER TO postgres;

--
-- Name: personel; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.personel (
    personel_no integer NOT NULL,
    personel_ad character varying(32) NOT NULL,
    personel_soyad character varying(20) NOT NULL,
    personel_departmant character(1),
    personel_mudur integer,
    personel_id integer DEFAULT 0 NOT NULL
);


ALTER TABLE public.personel OWNER TO postgres;

--
-- Name: personel_personel_no_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.personel ALTER COLUMN personel_no ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.personel_personel_no_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
    CYCLE
);


--
-- Name: saglayicilar; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.saglayicilar (
    saglayici_id integer NOT NULL,
    saglayici_adi character varying(20) NOT NULL,
    saglayici_temsilcisi_adsoyad character varying(128),
    saglayici_temsilcisi_tel character varying(18)
);


ALTER TABLE public.saglayicilar OWNER TO postgres;

--
-- Name: saglayicilar_saglayici_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.saglayicilar ALTER COLUMN saglayici_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.saglayicilar_saglayici_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: sepet; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.sepet (
    sepet_id integer NOT NULL,
    urun_id integer NOT NULL,
    urun_sayisi integer NOT NULL,
    sepet_instance integer NOT NULL
);


ALTER TABLE public.sepet OWNER TO postgres;

--
-- Name: sepet_sepet_instance_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.sepet ALTER COLUMN sepet_instance ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.sepet_sepet_instance_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: urunler; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.urunler (
    urun_id integer NOT NULL,
    urun_adi character varying(32) NOT NULL,
    urun_sayisi integer NOT NULL,
    urun_indirim_durumu boolean DEFAULT false NOT NULL,
    urun_turu character varying(16) NOT NULL,
    urun_uretim_tarihi character varying(16),
    urun_markasi integer NOT NULL,
    urun_saglayicisi integer NOT NULL,
    urun_fiyati integer
);


ALTER TABLE public.urunler OWNER TO postgres;

--
-- Name: urunler_urun_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.urunler ALTER COLUMN urun_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.urunler_urun_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Data for Name: banka_odemesi; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: entry; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.entry VALUES
	('tester', 'test'),
	('test3', 'test'),
	('test', 'test');


--
-- Data for Name: fatura; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.fatura OVERRIDING SYSTEM VALUE VALUES
	(20, 3, 20, 20, 1, false),
	(19, 4, 19, 19, 1, false),
	(17, 3, 17, 17, 1, false),
	(18, 3, 18, 18, 1, false),
	(16, 3, 16, 16, 1, false),
	(15, 3, 15, 15, 1, false),
	(14, 3, 14, 14, 44, false),
	(13, 1, 13, 13, 7, false),
	(12, 1, 12, 12, 1, false),
	(11, 4, 11, 11, 4, false),
	(10, 4, 10, 10, 4, false),
	(9, 4, 9, 9, 2, false),
	(8, 4, 8, 8, 3, false),
	(7, 4, 7, 7, 1, false),
	(24, 1, 24, 24, 1, false),
	(29, 4, 29, 29, 8, false),
	(22, 4, 22, 22, 459, false),
	(23, 5, 23, 23, 459, false),
	(21, 3, 21, 21, 459, false),
	(25, 2, 25, 25, 459, false),
	(26, 2, 26, 26, 459, false),
	(27, 1, 27, 27, 459, false),
	(28, 4, 28, 28, 459, false),
	(33, 4, 33, 33, 459, false),
	(35, 4, 35, 35, 459, false),
	(32, 3, 32, 32, 411, false),
	(34, 2, 34, 34, 1, false);


--
-- Data for Name: geri_iade; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.geri_iade OVERRIDING SYSTEM VALUE VALUES
	(3, 1, 12, 12, '');


--
-- Data for Name: iller; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.iller VALUES
	(1, '﻿Adana'),
	(2, 'Adıyaman'),
	(3, 'Afyon'),
	(4, 'Ağrı'),
	(5, 'Amasya'),
	(6, 'Ankara'),
	(7, 'Antalya'),
	(8, 'Artvin'),
	(9, 'Aydın'),
	(10, 'Balıkesir'),
	(11, 'Bilecik'),
	(12, 'Bingöl'),
	(13, 'Bitlis'),
	(14, 'Bolu'),
	(15, 'Burdur'),
	(16, 'Bursa'),
	(17, 'Çanakkale'),
	(18, 'Çankırı'),
	(19, 'Çorum'),
	(20, 'Denizli'),
	(21, 'Diyarbakır'),
	(22, 'Edirne'),
	(23, 'Elazığ'),
	(24, 'Erzincan'),
	(25, 'Erzurum'),
	(26, 'Eskişehir'),
	(27, 'Gaziantep'),
	(28, 'Giresun'),
	(29, 'Gümüşhane'),
	(30, 'Hakkari'),
	(31, 'Hatay'),
	(32, 'Isparta'),
	(33, 'Mersin'),
	(34, 'İstanbul'),
	(35, 'İzmir'),
	(36, 'Kars'),
	(37, 'Kastamonu'),
	(38, 'Kayseri'),
	(39, 'Kırklareli'),
	(40, 'Kırşehir'),
	(41, 'Kocaeli'),
	(42, 'Konya'),
	(43, 'Kütahya'),
	(44, 'Malatya'),
	(45, 'Manisa'),
	(46, 'K.Maraş'),
	(47, 'Mardin'),
	(48, 'Muğla'),
	(49, 'Muş'),
	(50, 'Nevşehir'),
	(51, 'Niğde'),
	(52, 'Ordu'),
	(53, 'Rize'),
	(54, 'Sakarya'),
	(55, 'Samsun'),
	(56, 'Siirt'),
	(57, 'Sinop'),
	(58, 'Sivas'),
	(59, 'Tekirdağ'),
	(60, 'Tokat'),
	(61, 'Trabzon'),
	(62, 'Tunceli'),
	(63, 'Şanlıurfa'),
	(64, 'Uşak'),
	(65, 'Van'),
	(66, 'Yozgat'),
	(67, 'Zonguldak'),
	(68, 'Aksaray'),
	(69, 'Bayburt'),
	(70, 'Karaman'),
	(71, 'Kırıkkale'),
	(72, 'Batman'),
	(73, 'Şırnak'),
	(74, 'Bartın'),
	(75, 'Ardahan'),
	(76, 'Iğdır'),
	(77, 'Yalova'),
	(78, 'Karabük'),
	(79, 'Kilis'),
	(80, 'Osmaniye'),
	(81, 'Düzce');


--
-- Data for Name: kargo_sirketi; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.kargo_sirketi OVERRIDING SYSTEM VALUE VALUES
	(1, 'HDL', 'Gökhan Vargil', '90 532 919 3465'),
	(2, 'Amazing Logistics', 'Fulya Fenci', '90 533 583 7756'),
	(3, 'FeedEx', 'Arif Can', NULL),
	(4, 'PUS', NULL, '90 552 369 8511'),
	(5, 'Yavaş Kargo', 'Ece Genç', '90 535 346 1121');


--
-- Data for Name: marka; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.marka OVERRIDING SYSTEM VALUE VALUES
	(1, 'Azus', 'Almanya'),
	(2, 'Elma', 'Turkiye'),
	(3, 'Zamsung', 'Güney Kore'),
	(4, 'Sany', 'Almanya'),
	(5, 'Philip', 'Japonya'),
	(6, 'Nakoi', 'Japonya'),
	(7, 'WBM', 'Almanya'),
	(8, 'GL', 'Güney Kore'),
	(9, 'MacroSoft', 'İngiltere'),
	(10, 'Bepis', 'ABD');


--
-- Data for Name: musteriler; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.musteriler OVERRIDING SYSTEM VALUE VALUES
	(1, 'Pınar Eda', 'Aydın', NULL, 12),
	(2, 'Ülkü', 'Gürsoy', NULL, 76),
	(3, 'Derya', 'Hasanoğlu', NULL, 44),
	(4, 'Eren', 'Yılmaz', NULL, 66),
	(5, 'Lale', 'Sabır', NULL, 65),
	(6, 'Gonca', 'Gezgin', NULL, 62),
	(7, 'Suna', 'Okur', NULL, 66),
	(8, 'Ali Fatih', 'Ulusoy', NULL, 57),
	(9, 'Pınar', 'Yiğit', NULL, 35),
	(10, 'Peyami', 'Tunalı', NULL, 73),
	(11, 'Banu', 'Koç', NULL, 56),
	(12, 'Pınar', 'Levent', NULL, 49),
	(13, 'Olcay', 'Orkun', NULL, 24),
	(14, 'Arzu', 'Kılıç', NULL, 23),
	(15, 'Aysel', 'Şeker', NULL, 51),
	(16, 'Nur', 'Manavgat', NULL, 56),
	(17, 'Leyla', 'Kaya', NULL, 66),
	(18, 'Uzay', 'Nazım', NULL, 44),
	(19, 'Hasan', 'Arslan', NULL, 23),
	(20, 'Levent', 'Gün', NULL, 8),
	(21, 'Ceyda', 'Sabır', NULL, 25),
	(22, 'Fikret', 'Gün', NULL, 54),
	(23, 'Naz', 'Nazım', NULL, 64),
	(24, 'Ilgaz', 'Bozkurt', NULL, 38),
	(25, 'Kaan', 'Ulusoy', NULL, 3),
	(26, 'Necdet', 'Uslu', NULL, 33),
	(27, 'Ayşe', 'Dereli', NULL, 42),
	(28, 'Doruk', 'Çalışkan', NULL, 19),
	(29, 'Ece', 'Sevgili', NULL, 62),
	(30, 'Gani', 'Uslu', NULL, 10),
	(31, 'Papatya', 'Hasanoğlu', NULL, 76),
	(32, 'Mustafa', 'Bozkurt', NULL, 10),
	(33, 'Levent', 'Temiz', NULL, 43),
	(34, 'Orhon', 'Yenen', NULL, 56),
	(35, 'Hasan', 'Kurt', NULL, 39),
	(36, 'Zeki', 'Meteci', NULL, 41),
	(37, 'Doğa', 'Zeytin', NULL, 57),
	(38, 'Duygu', 'Yıldız', NULL, 56),
	(39, 'Rahmi', 'Gün', NULL, 42),
	(40, 'Sema', 'Yılmaz', NULL, 9),
	(41, 'Papatya', 'Ulusoy', NULL, 26),
	(42, 'Rahmi', 'Kayaman', NULL, 40),
	(43, 'Irmak', 'Dereli', NULL, 50),
	(44, 'Lokman', 'Ilgaz', NULL, 23),
	(45, 'İpek', 'Özkan', NULL, 37),
	(46, 'Mert', 'Genç', NULL, 5),
	(47, 'Yavuz', 'Doğan', NULL, 10),
	(48, 'Rüzgar', 'Lapsekili', NULL, 22),
	(49, 'Ceyda', 'Lapsekili', NULL, 52),
	(50, 'Celil', 'Tekin', NULL, 12),
	(51, 'Rüzgar', 'Çalışkan', NULL, 34),
	(52, 'Fatmanur', 'Dal', NULL, 24),
	(53, 'Yağmur', 'Zeytin', NULL, 80),
	(54, 'Rüya', 'Çalışkan', NULL, 69),
	(55, 'Bilge', 'Akman', NULL, 37),
	(56, 'İpek', 'Okur', NULL, 70),
	(57, 'Ceyda', 'Yavuz', NULL, 41),
	(58, 'Arzu', 'Alkan', NULL, 62),
	(59, 'İnal', 'Bozkurt', NULL, 48),
	(60, 'Alara', 'Kılıç', NULL, 48),
	(61, 'Celil', 'Randa', NULL, 59),
	(62, 'Zeren', 'Gümüş', NULL, 13),
	(63, 'Gonca', 'Uslu', NULL, 62),
	(64, 'Ceren', 'Gümüş', NULL, 80),
	(65, 'Koray', 'Kayalı', NULL, 11),
	(66, 'Yağmur', 'Ulusoy', NULL, 68),
	(67, 'Elif Eda', 'Acar', NULL, 67),
	(68, 'Deniz Can', 'Yenen', NULL, 55),
	(69, 'Orhan', 'Lapsekili', NULL, 19),
	(70, 'Ilgar', 'Yenen', NULL, 66),
	(71, 'Perihan', 'Köksal', NULL, 3),
	(72, 'Oya', 'Dal', NULL, 63),
	(73, 'Ali Fatih', 'Ilgaz', NULL, 5),
	(74, 'Mert', 'Sevgili', NULL, 31),
	(75, 'Can', 'Akman', NULL, 67),
	(76, 'Orhan', 'Kurtoğlu', NULL, 58),
	(77, 'Peyami', 'Parlak', NULL, 8),
	(78, 'Kaya', 'Dal', NULL, 34),
	(79, 'Ezgi', 'Gürsoy', NULL, 52),
	(80, 'Mutlu', 'Demir', NULL, 68),
	(81, 'Fatih', 'Kılıç', NULL, 11),
	(82, 'Celil', 'Vargil', NULL, 15),
	(83, 'Volkan', 'Can', NULL, 45),
	(84, 'Feray', 'Köksal', NULL, 46),
	(85, 'Mine', 'Tatlibal', NULL, 23),
	(86, 'Hasan Ali', 'Ekermen', NULL, 10),
	(87, 'Selin', 'Zeytin', NULL, 62),
	(88, 'Selin', 'Yıldız', NULL, 21),
	(89, 'Kübra', 'Kaya', NULL, 66),
	(90, 'Kaya', 'Okur', NULL, 2),
	(91, 'Deniz Can', 'Sezer', NULL, 52),
	(92, 'Hülya', 'Ulusoy', NULL, 31),
	(93, 'Elif', 'Akyol', NULL, 80),
	(94, 'Safa', 'Vargil', NULL, 45),
	(95, 'Yusuf', 'Kayaman', NULL, 70),
	(96, 'Peyami', 'Sevgili', NULL, 65),
	(97, 'İpek', 'Ilgaz', NULL, 63),
	(98, 'Damla', 'Dal', NULL, 1),
	(99, 'Baykam', 'Ekermen', NULL, 24),
	(100, 'Deniz Can', 'Randa', NULL, 28),
	(101, 'Irmak', 'Kara', NULL, 19),
	(102, 'Gonca', 'Aslan', NULL, 3),
	(103, 'Papatya', 'Kayalı', NULL, 65),
	(104, 'Arif', 'Ilgaz', NULL, 70),
	(105, 'Mustafa Kemal', 'Yıldırım', NULL, 20),
	(106, 'Deniz Can', 'Nalbant', NULL, 50),
	(107, 'Varol', 'Tuna', NULL, 22),
	(108, 'Yavuz', 'Aksu', NULL, 44),
	(109, 'Binnur', 'Arslan', NULL, 7),
	(110, 'Ruhi', 'Demir', NULL, 12),
	(111, 'Yaprak', 'Özdemir', NULL, 69),
	(112, 'Yavuz', 'Bilgin', NULL, 5),
	(113, 'Suna', 'Aslan', NULL, 21),
	(114, 'Altay', 'Manavgat', NULL, 74),
	(115, 'Varol', 'Bolluk', NULL, 45),
	(116, 'İnal', 'Vargil', NULL, 29),
	(118, 'Feray', 'Limoncu', NULL, 2),
	(119, 'Damla', 'Orkun', NULL, 67),
	(120, 'Burcu', 'Egeli', NULL, 72),
	(121, 'Fatmanur', 'Köksal', NULL, 69),
	(122, 'Kübra', 'Alptekin', NULL, 33),
	(123, 'Leyla', 'Kaplan', NULL, 33),
	(124, 'Yaprak', 'Zincir', NULL, 37),
	(125, 'Yıldız', 'Bilgili', NULL, 6),
	(126, 'Arif', 'Coşkun', NULL, 14),
	(127, 'Rahmi', 'Egemen', NULL, 40),
	(128, 'Binnur', 'Kara', NULL, 79),
	(129, 'Filiz', 'Altın', NULL, 81),
	(130, 'Aydin', 'Yıldırım', NULL, 23),
	(131, 'Gülay', 'Çetin', NULL, 25),
	(132, 'Leyla', 'Kılıç', NULL, 21),
	(133, 'Murat Ali', 'Limoncu', NULL, 5),
	(134, 'Fatmanur', 'Köksal', NULL, 30),
	(135, 'Rüya', 'Dereli', NULL, 41),
	(136, 'Kutay', 'Bilgiç', NULL, 17),
	(137, 'Ece', 'Sezer', NULL, 25),
	(138, 'Can Ali', 'Bilgili', NULL, 62),
	(139, 'Ali Fatih', 'Sevgili', NULL, 35),
	(140, 'Kevser', 'Baray', NULL, 43),
	(141, 'Mert', 'Sabır', NULL, 25),
	(142, 'İnal', 'Koç', NULL, 41),
	(143, 'Güneş', 'Özdemir', NULL, 77),
	(144, 'Tuna', 'Genç', NULL, 31),
	(145, 'Ada', 'Gezgin', NULL, 71),
	(146, 'Zeki', 'Sabır', NULL, 61),
	(147, 'Safa', 'Kılıç', NULL, 74),
	(148, 'Papatya', 'Çelik', NULL, 39),
	(149, 'Can Umut', 'Akyol', NULL, 57),
	(150, 'Ceylan', 'Tekin', NULL, 63),
	(151, 'Tuba', 'Demir', NULL, 7),
	(152, 'Yaprak', 'Orkun', NULL, 25),
	(153, 'Hasan', 'Yıldırım', NULL, 15),
	(154, 'Canan', 'Kara', NULL, 81),
	(155, 'Kaya', 'Zincir', NULL, 67),
	(156, 'Elif', 'Akyol', NULL, 21),
	(157, 'Esin', 'Gün', NULL, 54),
	(158, 'Ali Emin', 'Manavgat', NULL, 7),
	(159, 'Aleyna', 'Vargil', NULL, 48),
	(160, 'Mustafa Kemal', 'Sezer', NULL, 3),
	(161, 'Altay', 'Bilgin', NULL, 51),
	(162, 'Deniz', 'Orkun', NULL, 14),
	(163, 'Furkan', 'Öztürk', NULL, 37),
	(164, 'Kamile', 'Tekin', NULL, 8),
	(165, 'Ayçe', 'Ekermen', NULL, 81),
	(166, 'Murat Ali', 'Yıldız', NULL, 71),
	(167, 'Baran', 'Ekermen', NULL, 77),
	(168, 'Ege', 'Sevgili', NULL, 36),
	(169, 'Zeki', 'Tekin', NULL, 42),
	(170, 'Ali', 'Gürsoy', NULL, 10),
	(171, 'Kübra', 'Şen', NULL, 75),
	(172, 'Zeren', 'Gün', NULL, 65),
	(173, 'Banu', 'Arslan', NULL, 58),
	(174, 'Zarife', 'Meteci', NULL, 39),
	(175, 'Can Ali', 'Çetin', NULL, 7),
	(176, 'Alev', 'Lapsekili', NULL, 63),
	(177, 'Gökhan', 'Şimşek', NULL, 59),
	(178, 'Hande', 'Şen', NULL, 20),
	(179, 'Uzay', 'Aksoy', NULL, 67),
	(180, 'Nuh', 'Genç', NULL, 7),
	(181, 'Leyla', 'Baray', NULL, 33),
	(182, 'Mustafa Ali', 'Kılıç', NULL, 76),
	(183, 'Necdet', 'Akman', NULL, 38),
	(184, 'Olcay', 'Şeker', NULL, 35),
	(185, 'Leyla', 'Bozkurt', NULL, 23),
	(186, 'Ayçe', 'Poyraz', NULL, 50),
	(187, 'Deniz Can', 'Zeytin', NULL, 39),
	(188, 'Ercan', 'Yılmaz', NULL, 16),
	(189, 'Feray', 'Poyraz', NULL, 74),
	(190, 'Pınar Eda', 'Acar', NULL, 33),
	(191, 'Eren', 'Şimşek', NULL, 26),
	(192, 'Perihan', 'Ulusoy', NULL, 47),
	(193, 'Yaprak', 'Randa', NULL, 12),
	(194, 'Melis', 'Aksu', NULL, 81),
	(195, 'Jale', 'Randa', NULL, 5),
	(196, 'Perihan', 'Gezgin', NULL, 66),
	(197, 'Eda', 'Yenen', NULL, 41),
	(198, 'Naz', 'Yılmaz', NULL, 27),
	(199, 'Naz', 'Coşkun', NULL, 3),
	(200, 'Ata', 'Gürsoy', NULL, 47),
	(201, 'Elif', 'Ekermen', NULL, 23),
	(202, 'Celil', 'Rasim', NULL, 65),
	(203, 'Mustafa', 'Kurt', NULL, 77),
	(204, 'Aysel', 'Parlak', NULL, 39),
	(205, 'Furkan', 'Kayaman', NULL, 69),
	(206, 'İpek', 'Sevgili', NULL, 22),
	(207, 'Sevinc', 'Şeker', NULL, 78),
	(208, 'Damla', 'Lapsekili', NULL, 61),
	(209, 'Gamze', 'Kayalı', NULL, 64),
	(210, 'Yavuz', 'Bozkurt', NULL, 37),
	(211, 'Leyla', 'Orkun', NULL, 14),
	(212, 'Kevser', 'Limoncu', NULL, 46),
	(213, 'Rüya', 'Kaya', NULL, 21),
	(214, 'Banu', 'Altınbaş', NULL, 47),
	(215, 'Umut', 'Alkan', NULL, 33),
	(216, 'Gül', 'Yılmaz', NULL, 65),
	(217, 'Doğa', 'Uslu', NULL, 70),
	(218, 'Esin', 'Bozkurt', NULL, 27),
	(219, 'Yıldız', 'Sezer', NULL, 5),
	(220, 'Ata', 'Okur', NULL, 76),
	(221, 'Efe', 'Bilgiç', NULL, 15),
	(222, 'Gökhan', 'Lapsekili', NULL, 14),
	(223, 'Lale', 'Tatlibal', NULL, 36),
	(224, 'Handan', 'Çetinkaya', NULL, 58),
	(225, 'Yıldız', 'Temiz', NULL, 54),
	(226, 'Can Ali', 'Manavgat', NULL, 46),
	(227, 'Celil', 'Yavuz', NULL, 24),
	(228, 'Hasan Tahsin', 'Aydın', NULL, 11),
	(229, 'Altay', 'Yiğit', NULL, 2),
	(230, 'Furkan', 'Bilgiç', NULL, 63),
	(231, 'Doga', 'Yıldırım', NULL, 21),
	(232, 'Filiz', 'Aslan', NULL, 46),
	(233, 'Nil', 'Aksoy', NULL, 28),
	(234, 'Nurperi', 'Acar', NULL, 50),
	(235, 'Baykam', 'Sezer', NULL, 66),
	(236, 'Canan', 'Özyurt', NULL, 52),
	(237, 'Hasan', 'Yerliyurt', NULL, 52),
	(238, 'Melis', 'Bozkurt', NULL, 23),
	(239, 'Ayşe', 'Aydın', NULL, 48),
	(240, 'Banu', 'Sevgili', NULL, 35),
	(241, 'İnal', 'Kaya', NULL, 39),
	(242, 'Gülay', 'Avcı', NULL, 18),
	(243, 'Feray', 'Ekermen', NULL, 17),
	(244, 'Lale', 'Onur', NULL, 26),
	(245, 'Kübra', 'Yılmaz', NULL, 37),
	(246, 'Aydin', 'Kaplan', NULL, 10),
	(247, 'Baykam', 'Baray', NULL, 30),
	(248, 'Berki', 'Özdemir', NULL, 39),
	(249, 'Melek', 'Yıldırım', NULL, 19),
	(250, 'Atakan', 'Kılıç', NULL, 70),
	(251, 'Derya', 'Şahin', NULL, 49);
INSERT INTO public.musteriler OVERRIDING SYSTEM VALUE VALUES
	(252, 'Sabri', 'Nalbant', NULL, 28),
	(253, 'Tülin', 'Altıntaş', NULL, 30),
	(254, 'Fatmanur', 'Onur', NULL, 8),
	(255, 'Çiçek', 'Güven', NULL, 30),
	(256, 'Bora', 'Zeytin', NULL, 59),
	(257, 'Ezgi', 'Egemen', NULL, 10),
	(258, 'İpek', 'Akman', NULL, 20),
	(259, 'Hülya', 'Bolluk', NULL, 55),
	(260, 'Çiçek', 'Karakaya', NULL, 18),
	(261, 'Doğa', 'Arslan', NULL, 11),
	(262, 'Burcu', 'Altıntaş', NULL, 78),
	(263, 'Aysel', 'Çetinkaya', NULL, 49),
	(264, 'Sevda', 'Poyraz', NULL, 66),
	(265, 'Güneş', 'Koç', NULL, 28),
	(266, 'Ali', 'Özkan', NULL, 72),
	(267, 'Eren', 'Kılıç', NULL, 10),
	(268, 'Ayşe', 'Tuna', NULL, 27),
	(269, 'Doruk', 'Ulusoy', NULL, 36),
	(270, 'Kemal', 'Yılmaz', NULL, 70),
	(271, 'Gökhan', 'Nazım', NULL, 15),
	(272, 'Hayal', 'Dal', NULL, 30),
	(273, 'Olcay', 'Kurt', NULL, 81),
	(274, 'Ada', 'Güven', NULL, 23),
	(275, 'Selin', 'Şeker', NULL, 2),
	(276, 'Buket', 'Koç', NULL, 52),
	(277, 'Hande', 'Öztürk', NULL, 13),
	(278, 'Lale', 'Güven', NULL, 38),
	(279, 'Yağmur', 'Gezgin', NULL, 35),
	(280, 'Ege', 'Randa', NULL, 69),
	(281, 'Baykam', 'Uslu', NULL, 59),
	(282, 'Deniz Can', 'Aslan', NULL, 62),
	(283, 'Ruhi', 'Bilgiç', NULL, 45),
	(284, 'Ata', 'Çalışkan', NULL, 26),
	(285, 'Erhan', 'Genç', NULL, 28),
	(286, 'Peyami', 'Yavuz', NULL, 74),
	(287, 'Rüzgar', 'Çelik', NULL, 19),
	(288, 'Pınar', 'Hasanoğlu', NULL, 7),
	(289, 'Hasan', 'Gümüş', NULL, 77),
	(290, 'Pınar', 'Çalışkan', NULL, 21),
	(291, 'Rahmi', 'Aydın', NULL, 78),
	(292, 'Rüya', 'Demir', NULL, 28),
	(293, 'Ceren', 'Dereli', NULL, 33),
	(294, 'Doruk', 'Poyraz', NULL, 80),
	(295, 'Cumhur', 'Şimşek', NULL, 50),
	(296, 'Fatma', 'Çetin', NULL, 81),
	(297, 'Necdet', 'Dal', NULL, 36),
	(298, 'Fatmanur', 'Bilgili', NULL, 69),
	(299, 'Okyay', 'Koç', NULL, 3),
	(300, 'Yaprak', 'Yavuz', NULL, 30),
	(301, 'Mehtap', 'Ekermen', NULL, 22),
	(302, 'Kutay', 'Şimşek', NULL, 16),
	(303, 'Vildan', 'Karakaya', NULL, 10),
	(304, 'Doğa', 'Yavuz', NULL, 39),
	(305, 'Koray', 'Akyol', NULL, 67),
	(306, 'Güneş', 'Çalışkan', NULL, 77),
	(307, 'Ayhan', 'Ceviz', NULL, 34),
	(308, 'Hayal', 'Bilgili', NULL, 16),
	(309, 'Hasan Ali', 'Bilgili', NULL, 16),
	(310, 'Handan', 'Can', NULL, 62),
	(311, 'Ruhi', 'Poyraz', NULL, 16),
	(312, 'Yağmur', 'Randa', NULL, 39),
	(313, 'Efe', 'Yıldırım', NULL, 56),
	(314, 'Tuba', 'Fenci', NULL, 13),
	(315, 'Mustafa Ali', 'Ekermen', NULL, 47),
	(316, 'Baykam', 'Aydın', NULL, 75),
	(317, 'Yonca', 'Bozkurt', NULL, 73),
	(318, 'Lokman', 'Egeli', NULL, 49),
	(319, 'Berki', 'Dere', NULL, 12),
	(320, 'Mert', 'Şimşek', NULL, 19),
	(321, 'Eda', 'Yenen', NULL, 24),
	(322, 'Handan', 'Limoncu', NULL, 12),
	(323, 'Perihan', 'Kılıç', NULL, 18),
	(324, 'Vildan', 'Altınbaş', NULL, 25),
	(325, 'Kemal', 'Demir', NULL, 47),
	(326, 'Elif Eda', 'Parlak', NULL, 77),
	(327, 'Ülkü', 'Çalışkan', NULL, 11),
	(328, 'Mustafa Ali', 'Kayaman', NULL, 58),
	(329, 'Kamile', 'Yavuz', NULL, 42),
	(330, 'Yıldız', 'Lapsekili', NULL, 14),
	(331, 'Ayçe', 'Dal', NULL, 23),
	(332, 'Pınar Eda', 'Karakaya', NULL, 4),
	(333, 'Eser', 'Koç', NULL, 79),
	(334, 'Tülin', 'Nazım', NULL, 2),
	(335, 'Erhan', 'Kurtoğlu', NULL, 37),
	(336, 'Esra', 'Kurt', NULL, 9),
	(337, 'Ayşe', 'Bozkurt', NULL, 5),
	(338, 'Fikret', 'Egeli', NULL, 63),
	(339, 'Ceyda', 'Levent', NULL, 36),
	(340, 'Okyay', 'Arslan', NULL, 2),
	(341, 'Zeki', 'Arslan', NULL, 78),
	(342, 'Çiçek', 'Sabır', NULL, 43),
	(343, 'Jale', 'Yerliyurt', NULL, 56),
	(344, 'Levent', 'Bilgin', NULL, 76),
	(345, 'Ezgi', 'Çetin', NULL, 36),
	(346, 'İnci', 'Altıntaş', NULL, 64),
	(347, 'Umut', 'Kılıç', NULL, 53),
	(348, 'Perihan', 'Lapsekili', NULL, 33),
	(349, 'Tülin', 'Arslan', NULL, 80),
	(350, 'Yunus Emre', 'Egeli', NULL, 60),
	(351, 'Canan', 'Arslan', NULL, 70),
	(352, 'Güneş', 'Yerliyurt', NULL, 57),
	(353, 'Kutay', 'Şahin', NULL, 8),
	(354, 'Banu', 'Tunalı', NULL, 43),
	(355, 'Handan', 'Limoncu', NULL, 30),
	(356, 'Alev', 'Doğan', NULL, 70),
	(357, 'Can Umut', 'Manavgat', NULL, 57),
	(358, 'Yağmur', 'Aksoy', NULL, 75),
	(359, 'Yusuf', 'Sevgili', NULL, 29),
	(360, 'Nevin', 'Doğan', NULL, 8),
	(361, 'Banu', 'Zeytin', NULL, 43),
	(362, 'Derya', 'Aksoy', NULL, 73),
	(363, 'Safa', 'Koç', NULL, 11),
	(364, 'Yavuz', 'Dal', NULL, 48),
	(365, 'Berki', 'Baray', NULL, 1),
	(366, 'Deniz Can', 'Zincir', NULL, 48),
	(367, 'Kaan', 'Yenen', NULL, 2),
	(368, 'Gonca', 'Onur', NULL, 42),
	(369, 'Ezgi', 'Gürsoy', NULL, 14),
	(370, 'Ülkü', 'Kurt', NULL, 41),
	(371, 'Mehmet', 'Nazım', NULL, 40),
	(372, 'Mustafa Ali', 'Çelik', NULL, 60),
	(373, 'Ilgar', 'Acar', NULL, 32),
	(374, 'Yunus', 'Aksoy', NULL, 14),
	(375, 'Zarife', 'Çetin', NULL, 48),
	(376, 'Levent', 'Ulusoy', NULL, 35),
	(377, 'Koray', 'Çetin', NULL, 23),
	(378, 'Tahsin', 'Aksoy', NULL, 43),
	(379, 'Gökhan', 'Lapsekili', NULL, 16),
	(380, 'Elif', 'Dal', NULL, 73),
	(381, 'Ali Emin', 'Gürsoy', NULL, 60),
	(382, 'Hayal', 'Acar', NULL, 9),
	(383, 'Uzay', 'Aksoy', NULL, 21),
	(384, 'Banu', 'Genç', NULL, 56),
	(385, 'Nur', 'Can', NULL, 24),
	(386, 'Bahar', 'Akyol', NULL, 34),
	(387, 'Uzay', 'Nazım', NULL, 54),
	(388, 'Tuna', 'Özdemir', NULL, 9),
	(389, 'Gizem', 'Okur', NULL, 41),
	(390, 'Kaya', 'Dal', NULL, 20),
	(391, 'Ata', 'Yavuz', NULL, 52),
	(392, 'Burcu', 'Akman', NULL, 74),
	(393, 'Zarife', 'Şeker', NULL, 34),
	(394, 'Alev', 'Ilgaz', NULL, 12),
	(395, 'Tahsin', 'Rasim', NULL, 23),
	(396, 'Gamze', 'Ekermen', NULL, 54),
	(397, 'Güneş', 'Akyol', NULL, 12),
	(398, 'Gül', 'Coşkun', NULL, 4),
	(399, 'Yavuz', 'Zeytin', NULL, 19),
	(400, 'Ruhi', 'Demir', NULL, 8),
	(401, 'Suna', 'Gezgin', NULL, 40),
	(402, 'Defne', 'Ceviz', NULL, 47),
	(403, 'Pınar Eda', 'Ulusoy', NULL, 59),
	(404, 'Defne', 'Gümüş', NULL, 76),
	(405, 'Adem', 'Akman', NULL, 36),
	(406, 'Hayal', 'Koç', NULL, 25),
	(407, 'Bilge', 'Kayaman', NULL, 51),
	(408, 'Oktay', 'Limoncu', NULL, 20),
	(409, 'Celil', 'Dereli', NULL, 70),
	(410, 'Banu', 'Dereli', NULL, 1),
	(411, 'Ali', 'Genç', NULL, 39),
	(412, 'Ziya', 'Şen', NULL, 21),
	(413, 'Bora', 'Kaya', NULL, 46),
	(414, 'Nil', 'Köksal', NULL, 3),
	(415, 'Hande', 'Rasim', NULL, 32),
	(416, 'Doruk', 'Yılmaz', NULL, 9),
	(417, 'Baran', 'Ilgaz', NULL, 77),
	(418, 'Alara', 'Mutluer', NULL, 41),
	(419, 'Papatya', 'Vargil', NULL, 55),
	(420, 'Aydin', 'Nalbant', NULL, 81),
	(421, 'Naz', 'Kara', NULL, 9),
	(422, 'Celil', 'Nalbant', NULL, 73),
	(423, 'Pınar', 'Çetinkaya', NULL, 7),
	(424, 'Umut', 'Altıntaş', NULL, 47),
	(425, 'Gülay', 'Öztürk', NULL, 26),
	(426, 'Kutay', 'Gürsoy', NULL, 41),
	(427, 'Handan', 'Avcı', NULL, 55),
	(428, 'Celil', 'Meteci', NULL, 43),
	(429, 'Ali Fatih', 'Yılmaz', NULL, 37),
	(430, 'Levent', 'Randa', NULL, 46),
	(431, 'Buket', 'Aksoy', NULL, 50),
	(432, 'Gani', 'Limoncu', NULL, 36),
	(433, 'Fatmanur', 'Koç', NULL, 68),
	(434, 'Kevser', 'Egeli', NULL, 1),
	(435, 'Doruk', 'Okur', NULL, 43),
	(436, 'Volkan', 'Zeytin', NULL, 34),
	(437, 'Umut', 'Kurt', NULL, 8),
	(438, 'Mutlu', 'Ulusoy', NULL, 35),
	(439, 'Elif', 'Egemen', NULL, 18),
	(440, 'Arzu', 'Çelik', NULL, 43),
	(441, 'Canan', 'Dereli', NULL, 77),
	(442, 'Mustafa Ali', 'Manavgat', NULL, 59),
	(443, 'Hande', 'Bilgili', NULL, 14),
	(444, 'Kerem', 'Aksu', NULL, 50),
	(445, 'Irmak', 'Yiğit', NULL, 73),
	(446, 'Baykam', 'Tuna', NULL, 66),
	(447, 'Tuna', 'Avcı', NULL, 81),
	(448, 'Vildan', 'Kılıç', NULL, 6),
	(449, 'Elif', 'Bilgili', NULL, 41),
	(457, 'Ahmet', 'Ekmer', NULL, 61),
	(459, 'Orhun', 'Ekmer', NULL, 54);


--
-- Data for Name: per_calisma_saatleri; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: per_it; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: per_satis; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: per_yonetim; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: personel; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.personel OVERRIDING SYSTEM VALUE VALUES
	(6, '0', '0', '0', NULL, 0),
	(7, 'Test', 'Testçi', 'S', NULL, 1),
	(9, 'Damla', 'Çetinkaya', NULL, NULL, 2),
	(10, 'Can', 'Randa', NULL, NULL, 3),
	(11, 'Perihan', 'Limoncu', NULL, NULL, 4),
	(12, 'Uzay', 'Akyol', NULL, NULL, 5),
	(13, 'Kevser', 'Egemen', NULL, NULL, 6),
	(14, 'Eser', 'Çetinkaya', NULL, NULL, 7),
	(15, 'Hande', 'Rasim', NULL, NULL, 8),
	(16, 'Hasan Ali', 'Kurtoğlu', NULL, NULL, 9),
	(17, 'Filiz', 'Vargil', NULL, NULL, 10),
	(18, 'Doruk', 'Özyurt', NULL, NULL, 11),
	(19, 'Doruk', 'Ulusoy', NULL, NULL, 12),
	(20, 'Rüzgar', 'Bilgiç', NULL, NULL, 13),
	(21, 'Yusuf', 'Şeker', NULL, NULL, 14),
	(22, 'Efe', 'Öztürk', NULL, NULL, 15),
	(23, 'Yaprak', 'Ekermen', NULL, NULL, 16),
	(24, 'Tülin', 'Aksoy', NULL, NULL, 17),
	(25, 'Cumhur', 'Egemen', NULL, NULL, 18),
	(26, 'Vedat', 'Sabır', NULL, NULL, 19),
	(27, 'Aleyna', 'Köksal', NULL, NULL, 20),
	(28, 'Gani', 'Yiğit', NULL, NULL, 21),
	(29, 'Eda', 'Limoncu', NULL, NULL, 22),
	(30, 'Rüzgar', 'Çetinkaya', NULL, NULL, 23),
	(31, 'Ata', 'Doğan', NULL, NULL, 24),
	(32, 'Nur', 'Yiğit', NULL, NULL, 25),
	(33, 'Atakan', 'Tunalı', NULL, NULL, 26),
	(34, 'Ege', 'Nazım', NULL, NULL, 27),
	(35, 'Efe', 'Nazım', NULL, NULL, 28),
	(36, 'Olcay', 'Yılmaz', NULL, NULL, 29),
	(37, 'Ziya', 'Ekermen', NULL, NULL, 30),
	(38, 'Buket', 'Egemen', NULL, NULL, 31),
	(39, 'Ceyda', 'Çetin', NULL, NULL, 32),
	(40, 'Damla', 'Genç', NULL, NULL, 33),
	(41, 'Can', 'Avcı', NULL, NULL, 34),
	(42, 'Ata', 'Bilgin', NULL, NULL, 35),
	(43, 'Ali Fatih', 'Ilgaz', NULL, NULL, 36),
	(44, 'Sevinc', 'Şen', NULL, NULL, 37);


--
-- Data for Name: saglayicilar; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.saglayicilar OVERRIDING SYSTEM VALUE VALUES
	(2, 'Fatih Lojistic', 'Fikret Aksu', '264 441 7304'),
	(3, 'Vatancıl Bilgi.', 'Tolga Sezer', '264 795 2283'),
	(4, 'Devrem Dağıtım', 'Fikret Öztürk', '264 722 4902'),
	(5, 'Akdeniz Taşıma', 'Zeki Ilgaz', '264 340 9327'),
	(6, 'Demir Döküm', 'Lale Tunalı', '264 500 5916'),
	(7, 'Saat Başı Loj. LLT', 'Murat Alkan', '264 619 4405'),
	(8, 'Ece Dağıtım', 'Oktay Egemen', '264 483 5069'),
	(9, 'Papatya LLC', 'Papatya Vargil', '264 667 3906'),
	(10, 'Taşıyoruz Taşıma', 'Varol Ceviz', '264 712 1827'),
	(11, 'Tekstil Lojistik', 'Koray Tekin', '264 762 6411');


--
-- Data for Name: sepet; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.sepet OVERRIDING SYSTEM VALUE VALUES
	(12, 1, 1, 1),
	(12, 1, 1, 2),
	(12, 1, 1, 3),
	(12, 1, 1, 4),
	(12, 1, 1, 5),
	(13, 5, 7, 6),
	(14, 7, 44, 7),
	(15, 3, 1, 8),
	(16, 9, 16, 9),
	(17, 3, 1, 10),
	(18, 8, 1, 11),
	(19, 8, 1, 12),
	(20, 7, 1, 13),
	(20, 16, 1, 14),
	(20, 16, 1, 15),
	(20, 24, 1, 16),
	(21, 8, 459, 17),
	(21, 17, 459, 18),
	(22, 10, 459, 19),
	(22, 16, 459, 20),
	(23, 10, 1, 21),
	(24, 1, 1, 22),
	(24, 23, 3, 23),
	(24, 16, 1, 24),
	(24, 24, 1, 25),
	(25, 11, 2, 26),
	(25, 23, 25, 27),
	(26, 16, 1, 28),
	(27, 7, 1, 29),
	(27, 14, 12, 30),
	(28, 12, 1, 31),
	(29, 12, 1, 32),
	(32, 11, 1, 33),
	(33, 13, 1, 34),
	(34, 12, 1, 35),
	(34, 12, 1, 36),
	(35, 10, 1, 37);


--
-- Data for Name: urunler; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.urunler OVERRIDING SYSTEM VALUE VALUES
	(1, 'greysp', 66, false, 'OTHER', '10/03/2017', 5, 2, 254),
	(2, 'tvmove', 47, true, 'OTHER', '03/04/1992', 8, 9, 54),
	(3, 'Galaxy Tab 5', 46, true, 'Telefon', '08/08/2014', 10, 9, 555),
	(4, 'Matebook 1', 16, true, 'Laptop', '04/12/2003', 4, 9, 2548),
	(5, 'Ideapad M8', 91, false, 'Laptop', '01/01/2018', 6, 5, 552),
	(6, 'TLX Tab 10S', 67, true, 'Tablet', '28/07/1994', 4, 4, 451),
	(7, 'X515', 41, false, 'Laptop', '13/06/1993', 5, 8, 54),
	(8, 'HP 255 G8', 68, true, 'Laptop', '19/06/2004', 7, 8, 458),
	(9, 'MSA Optix G24C4', 78, true, 'Monitör', '17/03/2006', 2, 4, 484),
	(10, 'AyPhone 11', 56, false, 'Telefon', '09/04/2020', 7, 8, 24),
	(11, 'Galaxy A32', 4, true, 'Tablet', '17/04/2017', 7, 11, 484),
	(12, 'Note 10S', 95, true, 'Tablet', '25/11/2014', 2, 11, 555),
	(13, 'Galaxy A72', 73, false, 'Tablet', '28/02/2004', 2, 4, 520),
	(14, 'Arzum AR4200', 88, true, 'OTHER', '26/10/1994', 8, 2, 525),
	(15, 'MK345', 93, true, 'OTHER', '18/04/1993', 2, 8, 55),
	(16, 'Enco Buds', 100, true, 'OTHER', '01/10/2002', 10, 5, 596),
	(17, 'XGT 2060', 89, true, 'Ekran_Kartı', '14/09/2011', 1, 2, 999),
	(18, 'GT1030', 48, false, 'Ekran_Kartı', '05/03/1999', 4, 6, 656),
	(21, 'Test', 5555, false, 'Laptop', NULL, 3, 2, 999),
	(23, 'Tester', 5555, false, 'Test', '19-12-2021', 2, 3, 999),
	(24, 'Test Elemanı', 6666, true, 'OTHER', '19-12-2021', 4, 2, 999);


--
-- Name: banka_odemesi_banka_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.banka_odemesi_banka_id_seq', 1, false);


--
-- Name: fatura_banka_odemesi_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.fatura_banka_odemesi_seq', 35, true);


--
-- Name: fatura_fatura_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.fatura_fatura_id_seq', 35, true);


--
-- Name: fatura_sepet_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.fatura_sepet_id_seq', 35, true);


--
-- Name: geri_iade_geri_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.geri_iade_geri_id_seq', 3, true);


--
-- Name: kargo_sirketi_kargo_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.kargo_sirketi_kargo_id_seq', 5, true);


--
-- Name: marka_marka_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.marka_marka_id_seq', 10, true);


--
-- Name: musteriler_musteri_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.musteriler_musteri_id_seq', 459, true);


--
-- Name: per_calisma_saatleri_vardiya_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.per_calisma_saatleri_vardiya_id_seq', 6, true);


--
-- Name: personel_personel_no_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.personel_personel_no_seq', 44, true);


--
-- Name: saglayicilar_saglayici_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.saglayicilar_saglayici_id_seq', 11, true);


--
-- Name: sepet_sepet_instance_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.sepet_sepet_instance_seq', 37, true);


--
-- Name: urunler_urun_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.urunler_urun_id_seq', 24, true);


--
-- Name: banka_odemesi banka_odemesi_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.banka_odemesi
    ADD CONSTRAINT banka_odemesi_pkey PRIMARY KEY (islem_id);


--
-- Name: fatura fatura_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.fatura
    ADD CONSTRAINT fatura_pkey PRIMARY KEY (fatura_id);


--
-- Name: geri_iade geri_iade_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.geri_iade
    ADD CONSTRAINT geri_iade_pkey PRIMARY KEY (geri_id);


--
-- Name: iller iller_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.iller
    ADD CONSTRAINT iller_pkey PRIMARY KEY (il_id);


--
-- Name: kargo_sirketi kargo_sirketi_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kargo_sirketi
    ADD CONSTRAINT kargo_sirketi_pkey PRIMARY KEY (kargo_id);


--
-- Name: marka marka_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.marka
    ADD CONSTRAINT marka_pkey PRIMARY KEY (marka_id);


--
-- Name: musteriler musteriler_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.musteriler
    ADD CONSTRAINT musteriler_pkey PRIMARY KEY (musteri_id);


--
-- Name: per_calisma_saatleri per_calisma_saatleri_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.per_calisma_saatleri
    ADD CONSTRAINT per_calisma_saatleri_pkey PRIMARY KEY (vardiya_id);


--
-- Name: per_satis per_satis_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.per_satis
    ADD CONSTRAINT per_satis_pkey PRIMARY KEY (personel_id);


--
-- Name: personel personel_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.personel
    ADD CONSTRAINT personel_pkey PRIMARY KEY (personel_no);


--
-- Name: saglayicilar saglayicilar_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.saglayicilar
    ADD CONSTRAINT saglayicilar_pkey PRIMARY KEY (saglayici_id);


--
-- Name: sepet sepet_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sepet
    ADD CONSTRAINT sepet_pkey PRIMARY KEY (sepet_instance);


--
-- Name: banka_odemesi unique_banka_odemesi_fatura_id; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.banka_odemesi
    ADD CONSTRAINT unique_banka_odemesi_fatura_id UNIQUE (fatura_id);


--
-- Name: fatura unique_fatura_sepet_id; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.fatura
    ADD CONSTRAINT unique_fatura_sepet_id UNIQUE (sepet_id);


--
-- Name: kargo_sirketi unique_kargo_sirketi_kargo_ad; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kargo_sirketi
    ADD CONSTRAINT unique_kargo_sirketi_kargo_ad UNIQUE (kargo_ad);


--
-- Name: marka unique_marka_marka_adi; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.marka
    ADD CONSTRAINT unique_marka_marka_adi UNIQUE (marka_adi);


--
-- Name: saglayicilar unique_saglayicilar_saglayici_adi; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.saglayicilar
    ADD CONSTRAINT unique_saglayicilar_saglayici_adi UNIQUE (saglayici_adi);


--
-- Name: sepet unique_sepet_sepet_instance; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sepet
    ADD CONSTRAINT unique_sepet_sepet_instance UNIQUE (sepet_instance);


--
-- Name: urunler unique_urunler_urun_adi; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.urunler
    ADD CONSTRAINT unique_urunler_urun_adi UNIQUE (urun_adi);


--
-- Name: urunler urunler_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.urunler
    ADD CONSTRAINT urunler_pkey PRIMARY KEY (urun_id);


--
-- Name: index_il_id; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX index_il_id ON public.iller USING btree (il_id);


--
-- Name: index_personel_id; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX index_personel_id ON public.per_calisma_saatleri USING btree (personel_id);


--
-- Name: index_sepet_id; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX index_sepet_id ON public.sepet USING btree (sepet_id);


--
-- Name: geri_iade fat_to_geri; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.geri_iade
    ADD CONSTRAINT fat_to_geri FOREIGN KEY (fatura_id) REFERENCES public.fatura(fatura_id) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: banka_odemesi fatura_to_banka_lnk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.banka_odemesi
    ADD CONSTRAINT fatura_to_banka_lnk FOREIGN KEY (fatura_id) REFERENCES public.fatura(fatura_id) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: sepet fatura_to_sepet; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sepet
    ADD CONSTRAINT fatura_to_sepet FOREIGN KEY (sepet_id) REFERENCES public.fatura(sepet_id) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: musteriler il_to_musteri_lnk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.musteriler
    ADD CONSTRAINT il_to_musteri_lnk FOREIGN KEY (musteri_il_id) REFERENCES public.iller(il_id) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: per_satis il_to_per_sat; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.per_satis
    ADD CONSTRAINT il_to_per_sat FOREIGN KEY (bolge) REFERENCES public.iller(il_id) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: fatura kargo_to_fatura_lnk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.fatura
    ADD CONSTRAINT kargo_to_fatura_lnk FOREIGN KEY (kargo_sirketi) REFERENCES public.kargo_sirketi(kargo_id) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: urunler marka_to_urunler_lnk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.urunler
    ADD CONSTRAINT marka_to_urunler_lnk FOREIGN KEY (urun_markasi) REFERENCES public.marka(marka_id) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: fatura musteri_to_fatura; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.fatura
    ADD CONSTRAINT musteri_to_fatura FOREIGN KEY (musteri_id) REFERENCES public.musteriler(musteri_id) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: musteriler musteri_to_personel; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.musteriler
    ADD CONSTRAINT musteri_to_personel FOREIGN KEY (musteri_eleman_yakini) REFERENCES public.personel(personel_no) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: per_calisma_saatleri per_to_cal; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.per_calisma_saatleri
    ADD CONSTRAINT per_to_cal FOREIGN KEY (personel_id) REFERENCES public.personel(personel_no) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: geri_iade person_to_geri; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.geri_iade
    ADD CONSTRAINT person_to_geri FOREIGN KEY (personel_id) REFERENCES public.personel(personel_no) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: per_it person_to_it; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.per_it
    ADD CONSTRAINT person_to_it FOREIGN KEY (personel_id) REFERENCES public.personel(personel_no) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: per_satis person_to_sat; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.per_satis
    ADD CONSTRAINT person_to_sat FOREIGN KEY (personel_id) REFERENCES public.personel(personel_no) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: per_yonetim person_to_yon; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.per_yonetim
    ADD CONSTRAINT person_to_yon FOREIGN KEY (personel_id) REFERENCES public.personel(personel_no) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: urunler saglayici_to_urunler_lnk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.urunler
    ADD CONSTRAINT saglayici_to_urunler_lnk FOREIGN KEY (urun_saglayicisi) REFERENCES public.saglayicilar(saglayici_id) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: geri_iade urun_to_geri; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.geri_iade
    ADD CONSTRAINT urun_to_geri FOREIGN KEY (urun_id) REFERENCES public.urunler(urun_id) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: sepet urunler_to_sepet_lnk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sepet
    ADD CONSTRAINT urunler_to_sepet_lnk FOREIGN KEY (urun_id) REFERENCES public.urunler(urun_id) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- PostgreSQL database dump complete
--

