PGDMP  4                    }            sewa_lapangan    17.4    17.4 ]    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                           false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                           false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                           false            �           1262    17280    sewa_lapangan    DATABASE     s   CREATE DATABASE sewa_lapangan WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'en-US';
    DROP DATABASE sewa_lapangan;
                     postgres    false            �            1259    17663    cart_pemesanan    TABLE     �   CREATE TABLE public.cart_pemesanan (
    id_cart integer NOT NULL,
    id_user integer NOT NULL,
    id_jadwal integer NOT NULL,
    tanggal_ditambahkan timestamp without time zone DEFAULT now()
);
 "   DROP TABLE public.cart_pemesanan;
       public         heap r       postgres    false            �            1259    17662    cart_pemesanan_id_cart_seq    SEQUENCE     �   CREATE SEQUENCE public.cart_pemesanan_id_cart_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public.cart_pemesanan_id_cart_seq;
       public               postgres    false    236            �           0    0    cart_pemesanan_id_cart_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public.cart_pemesanan_id_cart_seq OWNED BY public.cart_pemesanan.id_cart;
          public               postgres    false    235            �            1259    17345    detail_pemesanan    TABLE     �   CREATE TABLE public.detail_pemesanan (
    id_detail integer NOT NULL,
    id_pemesanan integer NOT NULL,
    nama_pemesan character varying(100) NOT NULL,
    nohp_pemesan character varying(15) NOT NULL
);
 $   DROP TABLE public.detail_pemesanan;
       public         heap r       postgres    false            �            1259    17344    detail_pemesanan_id_detail_seq    SEQUENCE     �   CREATE SEQUENCE public.detail_pemesanan_id_detail_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 5   DROP SEQUENCE public.detail_pemesanan_id_detail_seq;
       public               postgres    false    228            �           0    0    detail_pemesanan_id_detail_seq    SEQUENCE OWNED BY     a   ALTER SEQUENCE public.detail_pemesanan_id_detail_seq OWNED BY public.detail_pemesanan.id_detail;
          public               postgres    false    227            �            1259    17301    jadwal_lapangan    TABLE     #  CREATE TABLE public.jadwal_lapangan (
    id_jadwal integer NOT NULL,
    id_lapangan integer NOT NULL,
    tanggal date NOT NULL,
    jam_mulai time without time zone NOT NULL,
    jam_selesai time without time zone NOT NULL,
    status character varying(50) NOT NULL,
    tarif integer
);
 #   DROP TABLE public.jadwal_lapangan;
       public         heap r       postgres    false            �            1259    17300    jadwal_lapangan_id_jadwal_seq    SEQUENCE     �   CREATE SEQUENCE public.jadwal_lapangan_id_jadwal_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 4   DROP SEQUENCE public.jadwal_lapangan_id_jadwal_seq;
       public               postgres    false    222            �           0    0    jadwal_lapangan_id_jadwal_seq    SEQUENCE OWNED BY     _   ALTER SEQUENCE public.jadwal_lapangan_id_jadwal_seq OWNED BY public.jadwal_lapangan.id_jadwal;
          public               postgres    false    221            �            1259    17282    jenis_lapangan    TABLE     v   CREATE TABLE public.jenis_lapangan (
    id_jenis integer NOT NULL,
    nama_jenis character varying(100) NOT NULL
);
 "   DROP TABLE public.jenis_lapangan;
       public         heap r       postgres    false            �            1259    17281    jenis_lapangan_id_jenis_seq    SEQUENCE     �   CREATE SEQUENCE public.jenis_lapangan_id_jenis_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 2   DROP SEQUENCE public.jenis_lapangan_id_jenis_seq;
       public               postgres    false    218            �           0    0    jenis_lapangan_id_jenis_seq    SEQUENCE OWNED BY     [   ALTER SEQUENCE public.jenis_lapangan_id_jenis_seq OWNED BY public.jenis_lapangan.id_jenis;
          public               postgres    false    217            �            1259    17289    lapangan    TABLE     �   CREATE TABLE public.lapangan (
    id_lapangan integer NOT NULL,
    nama_lapangan character varying(100) NOT NULL,
    id_jenis integer NOT NULL
);
    DROP TABLE public.lapangan;
       public         heap r       postgres    false            �            1259    17288    lapangan_id_lapangan_seq    SEQUENCE     �   CREATE SEQUENCE public.lapangan_id_lapangan_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public.lapangan_id_lapangan_seq;
       public               postgres    false    220            �           0    0    lapangan_id_lapangan_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public.lapangan_id_lapangan_seq OWNED BY public.lapangan.id_lapangan;
          public               postgres    false    219            �            1259    17382 
   log_status    TABLE     �   CREATE TABLE public.log_status (
    log_id integer NOT NULL,
    id_pemesanan integer NOT NULL,
    waktu_perubahan timestamp without time zone DEFAULT CURRENT_TIMESTAMP NOT NULL
);
    DROP TABLE public.log_status;
       public         heap r       postgres    false            �            1259    17381    log_status_log_id_seq    SEQUENCE     �   CREATE SEQUENCE public.log_status_log_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public.log_status_log_id_seq;
       public               postgres    false    234            �           0    0    log_status_log_id_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE public.log_status_log_id_seq OWNED BY public.log_status.log_id;
          public               postgres    false    233            �            1259    17357    metode_pembayaran    TABLE     �   CREATE TABLE public.metode_pembayaran (
    id_metode integer NOT NULL,
    nama_metode character varying(50) NOT NULL,
    no_va character varying(50)
);
 %   DROP TABLE public.metode_pembayaran;
       public         heap r       postgres    false            �            1259    17356    metode_pembayaran_id_metode_seq    SEQUENCE     �   CREATE SEQUENCE public.metode_pembayaran_id_metode_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 6   DROP SEQUENCE public.metode_pembayaran_id_metode_seq;
       public               postgres    false    230            �           0    0    metode_pembayaran_id_metode_seq    SEQUENCE OWNED BY     c   ALTER SEQUENCE public.metode_pembayaran_id_metode_seq OWNED BY public.metode_pembayaran.id_metode;
          public               postgres    false    229            �            1259    17364 
   pembayaran    TABLE     �  CREATE TABLE public.pembayaran (
    id_pembayaran integer NOT NULL,
    id_pemesanan integer NOT NULL,
    id_metode integer NOT NULL,
    waktu_pembayaran timestamp without time zone NOT NULL,
    status_pembayaran character varying(50) NOT NULL,
    CONSTRAINT cek_status_pembayaran CHECK (((status_pembayaran)::text = ANY ((ARRAY['Menunggu'::character varying, 'Lunas'::character varying, 'Gagal'::character varying])::text[])))
);
    DROP TABLE public.pembayaran;
       public         heap r       postgres    false            �            1259    17363    pembayaran_id_pembayaran_seq    SEQUENCE     �   CREATE SEQUENCE public.pembayaran_id_pembayaran_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 3   DROP SEQUENCE public.pembayaran_id_pembayaran_seq;
       public               postgres    false    232            �           0    0    pembayaran_id_pembayaran_seq    SEQUENCE OWNED BY     ]   ALTER SEQUENCE public.pembayaran_id_pembayaran_seq OWNED BY public.pembayaran.id_pembayaran;
          public               postgres    false    231            �            1259    17323 	   pemesanan    TABLE     �  CREATE TABLE public.pemesanan (
    id_pemesanan integer NOT NULL,
    id_user integer NOT NULL,
    id_lapangan integer NOT NULL,
    id_jadwal integer NOT NULL,
    status_pemesanan character varying(50) NOT NULL,
    total_biaya numeric(12,2) NOT NULL,
    tanggal_pesan date DEFAULT CURRENT_DATE,
    status_bayar character varying(20) DEFAULT 'Belum Bayar'::character varying
);
    DROP TABLE public.pemesanan;
       public         heap r       postgres    false            �            1259    17322    pemesanan_id_pemesanan_seq    SEQUENCE     �   CREATE SEQUENCE public.pemesanan_id_pemesanan_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public.pemesanan_id_pemesanan_seq;
       public               postgres    false    226            �           0    0    pemesanan_id_pemesanan_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public.pemesanan_id_pemesanan_seq OWNED BY public.pemesanan.id_pemesanan;
          public               postgres    false    225            �            1259    17684    rekening_admin    TABLE     �   CREATE TABLE public.rekening_admin (
    id integer NOT NULL,
    nama_bank character varying(50),
    nomor_rekening character varying(50),
    nama_rekening character varying(50)
);
 "   DROP TABLE public.rekening_admin;
       public         heap r       postgres    false            �            1259    17683    rekening_admin_id_seq    SEQUENCE     �   CREATE SEQUENCE public.rekening_admin_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public.rekening_admin_id_seq;
       public               postgres    false    238            �           0    0    rekening_admin_id_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE public.rekening_admin_id_seq OWNED BY public.rekening_admin.id;
          public               postgres    false    237            �            1259    17313    user    TABLE     �  CREATE TABLE public."user" (
    id_user integer NOT NULL,
    nama character varying(100) NOT NULL,
    email character varying(100) NOT NULL,
    password character varying(100) NOT NULL,
    role character varying(20) DEFAULT 'pengguna'::character varying NOT NULL,
    CONSTRAINT user_role_check CHECK (((role)::text = ANY ((ARRAY['admin'::character varying, 'pengguna'::character varying])::text[])))
);
    DROP TABLE public."user";
       public         heap r       postgres    false            �            1259    17312    user_id_user_seq    SEQUENCE     �   CREATE SEQUENCE public.user_id_user_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.user_id_user_seq;
       public               postgres    false    224            �           0    0    user_id_user_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public.user_id_user_seq OWNED BY public."user".id_user;
          public               postgres    false    223            �           2604    17666    cart_pemesanan id_cart    DEFAULT     �   ALTER TABLE ONLY public.cart_pemesanan ALTER COLUMN id_cart SET DEFAULT nextval('public.cart_pemesanan_id_cart_seq'::regclass);
 E   ALTER TABLE public.cart_pemesanan ALTER COLUMN id_cart DROP DEFAULT;
       public               postgres    false    236    235    236            �           2604    17348    detail_pemesanan id_detail    DEFAULT     �   ALTER TABLE ONLY public.detail_pemesanan ALTER COLUMN id_detail SET DEFAULT nextval('public.detail_pemesanan_id_detail_seq'::regclass);
 I   ALTER TABLE public.detail_pemesanan ALTER COLUMN id_detail DROP DEFAULT;
       public               postgres    false    227    228    228            �           2604    17304    jadwal_lapangan id_jadwal    DEFAULT     �   ALTER TABLE ONLY public.jadwal_lapangan ALTER COLUMN id_jadwal SET DEFAULT nextval('public.jadwal_lapangan_id_jadwal_seq'::regclass);
 H   ALTER TABLE public.jadwal_lapangan ALTER COLUMN id_jadwal DROP DEFAULT;
       public               postgres    false    221    222    222            �           2604    17285    jenis_lapangan id_jenis    DEFAULT     �   ALTER TABLE ONLY public.jenis_lapangan ALTER COLUMN id_jenis SET DEFAULT nextval('public.jenis_lapangan_id_jenis_seq'::regclass);
 F   ALTER TABLE public.jenis_lapangan ALTER COLUMN id_jenis DROP DEFAULT;
       public               postgres    false    218    217    218            �           2604    17292    lapangan id_lapangan    DEFAULT     |   ALTER TABLE ONLY public.lapangan ALTER COLUMN id_lapangan SET DEFAULT nextval('public.lapangan_id_lapangan_seq'::regclass);
 C   ALTER TABLE public.lapangan ALTER COLUMN id_lapangan DROP DEFAULT;
       public               postgres    false    219    220    220            �           2604    17385    log_status log_id    DEFAULT     v   ALTER TABLE ONLY public.log_status ALTER COLUMN log_id SET DEFAULT nextval('public.log_status_log_id_seq'::regclass);
 @   ALTER TABLE public.log_status ALTER COLUMN log_id DROP DEFAULT;
       public               postgres    false    234    233    234            �           2604    17360    metode_pembayaran id_metode    DEFAULT     �   ALTER TABLE ONLY public.metode_pembayaran ALTER COLUMN id_metode SET DEFAULT nextval('public.metode_pembayaran_id_metode_seq'::regclass);
 J   ALTER TABLE public.metode_pembayaran ALTER COLUMN id_metode DROP DEFAULT;
       public               postgres    false    230    229    230            �           2604    17367    pembayaran id_pembayaran    DEFAULT     �   ALTER TABLE ONLY public.pembayaran ALTER COLUMN id_pembayaran SET DEFAULT nextval('public.pembayaran_id_pembayaran_seq'::regclass);
 G   ALTER TABLE public.pembayaran ALTER COLUMN id_pembayaran DROP DEFAULT;
       public               postgres    false    231    232    232            �           2604    17326    pemesanan id_pemesanan    DEFAULT     �   ALTER TABLE ONLY public.pemesanan ALTER COLUMN id_pemesanan SET DEFAULT nextval('public.pemesanan_id_pemesanan_seq'::regclass);
 E   ALTER TABLE public.pemesanan ALTER COLUMN id_pemesanan DROP DEFAULT;
       public               postgres    false    225    226    226            �           2604    17687    rekening_admin id    DEFAULT     v   ALTER TABLE ONLY public.rekening_admin ALTER COLUMN id SET DEFAULT nextval('public.rekening_admin_id_seq'::regclass);
 @   ALTER TABLE public.rekening_admin ALTER COLUMN id DROP DEFAULT;
       public               postgres    false    237    238    238            �           2604    17316    user id_user    DEFAULT     n   ALTER TABLE ONLY public."user" ALTER COLUMN id_user SET DEFAULT nextval('public.user_id_user_seq'::regclass);
 =   ALTER TABLE public."user" ALTER COLUMN id_user DROP DEFAULT;
       public               postgres    false    223    224    224            �          0    17663    cart_pemesanan 
   TABLE DATA           Z   COPY public.cart_pemesanan (id_cart, id_user, id_jadwal, tanggal_ditambahkan) FROM stdin;
    public               postgres    false    236    v       �          0    17345    detail_pemesanan 
   TABLE DATA           _   COPY public.detail_pemesanan (id_detail, id_pemesanan, nama_pemesan, nohp_pemesan) FROM stdin;
    public               postgres    false    228   ^v       �          0    17301    jadwal_lapangan 
   TABLE DATA           q   COPY public.jadwal_lapangan (id_jadwal, id_lapangan, tanggal, jam_mulai, jam_selesai, status, tarif) FROM stdin;
    public               postgres    false    222   �v                 0    17282    jenis_lapangan 
   TABLE DATA           >   COPY public.jenis_lapangan (id_jenis, nama_jenis) FROM stdin;
    public               postgres    false    218   �v       �          0    17289    lapangan 
   TABLE DATA           H   COPY public.lapangan (id_lapangan, nama_lapangan, id_jenis) FROM stdin;
    public               postgres    false    220   "w       �          0    17382 
   log_status 
   TABLE DATA           K   COPY public.log_status (log_id, id_pemesanan, waktu_perubahan) FROM stdin;
    public               postgres    false    234   ww       �          0    17357    metode_pembayaran 
   TABLE DATA           J   COPY public.metode_pembayaran (id_metode, nama_metode, no_va) FROM stdin;
    public               postgres    false    230   �w       �          0    17364 
   pembayaran 
   TABLE DATA           q   COPY public.pembayaran (id_pembayaran, id_pemesanan, id_metode, waktu_pembayaran, status_pembayaran) FROM stdin;
    public               postgres    false    232   �w       �          0    17323 	   pemesanan 
   TABLE DATA           �   COPY public.pemesanan (id_pemesanan, id_user, id_lapangan, id_jadwal, status_pemesanan, total_biaya, tanggal_pesan, status_bayar) FROM stdin;
    public               postgres    false    226   x       �          0    17684    rekening_admin 
   TABLE DATA           V   COPY public.rekening_admin (id, nama_bank, nomor_rekening, nama_rekening) FROM stdin;
    public               postgres    false    238   \x       �          0    17313    user 
   TABLE DATA           F   COPY public."user" (id_user, nama, email, password, role) FROM stdin;
    public               postgres    false    224   �x       �           0    0    cart_pemesanan_id_cart_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public.cart_pemesanan_id_cart_seq', 4, true);
          public               postgres    false    235            �           0    0    detail_pemesanan_id_detail_seq    SEQUENCE SET     L   SELECT pg_catalog.setval('public.detail_pemesanan_id_detail_seq', 1, true);
          public               postgres    false    227            �           0    0    jadwal_lapangan_id_jadwal_seq    SEQUENCE SET     K   SELECT pg_catalog.setval('public.jadwal_lapangan_id_jadwal_seq', 4, true);
          public               postgres    false    221            �           0    0    jenis_lapangan_id_jenis_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.jenis_lapangan_id_jenis_seq', 3, true);
          public               postgres    false    217            �           0    0    lapangan_id_lapangan_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.lapangan_id_lapangan_seq', 9, true);
          public               postgres    false    219            �           0    0    log_status_log_id_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public.log_status_log_id_seq', 1, false);
          public               postgres    false    233            �           0    0    metode_pembayaran_id_metode_seq    SEQUENCE SET     M   SELECT pg_catalog.setval('public.metode_pembayaran_id_metode_seq', 2, true);
          public               postgres    false    229            �           0    0    pembayaran_id_pembayaran_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('public.pembayaran_id_pembayaran_seq', 1, true);
          public               postgres    false    231            �           0    0    pemesanan_id_pemesanan_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public.pemesanan_id_pemesanan_seq', 7, true);
          public               postgres    false    225            �           0    0    rekening_admin_id_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.rekening_admin_id_seq', 1, true);
          public               postgres    false    237            �           0    0    user_id_user_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.user_id_user_seq', 7, true);
          public               postgres    false    223            �           2606    17669 "   cart_pemesanan cart_pemesanan_pkey 
   CONSTRAINT     e   ALTER TABLE ONLY public.cart_pemesanan
    ADD CONSTRAINT cart_pemesanan_pkey PRIMARY KEY (id_cart);
 L   ALTER TABLE ONLY public.cart_pemesanan DROP CONSTRAINT cart_pemesanan_pkey;
       public                 postgres    false    236            �           2606    17350 &   detail_pemesanan detail_pemesanan_pkey 
   CONSTRAINT     k   ALTER TABLE ONLY public.detail_pemesanan
    ADD CONSTRAINT detail_pemesanan_pkey PRIMARY KEY (id_detail);
 P   ALTER TABLE ONLY public.detail_pemesanan DROP CONSTRAINT detail_pemesanan_pkey;
       public                 postgres    false    228            �           2606    17306 $   jadwal_lapangan jadwal_lapangan_pkey 
   CONSTRAINT     i   ALTER TABLE ONLY public.jadwal_lapangan
    ADD CONSTRAINT jadwal_lapangan_pkey PRIMARY KEY (id_jadwal);
 N   ALTER TABLE ONLY public.jadwal_lapangan DROP CONSTRAINT jadwal_lapangan_pkey;
       public                 postgres    false    222            �           2606    17287 "   jenis_lapangan jenis_lapangan_pkey 
   CONSTRAINT     f   ALTER TABLE ONLY public.jenis_lapangan
    ADD CONSTRAINT jenis_lapangan_pkey PRIMARY KEY (id_jenis);
 L   ALTER TABLE ONLY public.jenis_lapangan DROP CONSTRAINT jenis_lapangan_pkey;
       public                 postgres    false    218            �           2606    17294    lapangan lapangan_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.lapangan
    ADD CONSTRAINT lapangan_pkey PRIMARY KEY (id_lapangan);
 @   ALTER TABLE ONLY public.lapangan DROP CONSTRAINT lapangan_pkey;
       public                 postgres    false    220            �           2606    17388    log_status log_status_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.log_status
    ADD CONSTRAINT log_status_pkey PRIMARY KEY (log_id);
 D   ALTER TABLE ONLY public.log_status DROP CONSTRAINT log_status_pkey;
       public                 postgres    false    234            �           2606    17362 (   metode_pembayaran metode_pembayaran_pkey 
   CONSTRAINT     m   ALTER TABLE ONLY public.metode_pembayaran
    ADD CONSTRAINT metode_pembayaran_pkey PRIMARY KEY (id_metode);
 R   ALTER TABLE ONLY public.metode_pembayaran DROP CONSTRAINT metode_pembayaran_pkey;
       public                 postgres    false    230            �           2606    17370    pembayaran pembayaran_pkey 
   CONSTRAINT     c   ALTER TABLE ONLY public.pembayaran
    ADD CONSTRAINT pembayaran_pkey PRIMARY KEY (id_pembayaran);
 D   ALTER TABLE ONLY public.pembayaran DROP CONSTRAINT pembayaran_pkey;
       public                 postgres    false    232            �           2606    17328    pemesanan pemesanan_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.pemesanan
    ADD CONSTRAINT pemesanan_pkey PRIMARY KEY (id_pemesanan);
 B   ALTER TABLE ONLY public.pemesanan DROP CONSTRAINT pemesanan_pkey;
       public                 postgres    false    226            �           2606    17689 "   rekening_admin rekening_admin_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.rekening_admin
    ADD CONSTRAINT rekening_admin_pkey PRIMARY KEY (id);
 L   ALTER TABLE ONLY public.rekening_admin DROP CONSTRAINT rekening_admin_pkey;
       public                 postgres    false    238            �           2606    17321    user user_email_key 
   CONSTRAINT     Q   ALTER TABLE ONLY public."user"
    ADD CONSTRAINT user_email_key UNIQUE (email);
 ?   ALTER TABLE ONLY public."user" DROP CONSTRAINT user_email_key;
       public                 postgres    false    224            �           2606    17319    user user_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public."user"
    ADD CONSTRAINT user_pkey PRIMARY KEY (id_user);
 :   ALTER TABLE ONLY public."user" DROP CONSTRAINT user_pkey;
       public                 postgres    false    224            �           2606    17675 ,   cart_pemesanan cart_pemesanan_id_jadwal_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.cart_pemesanan
    ADD CONSTRAINT cart_pemesanan_id_jadwal_fkey FOREIGN KEY (id_jadwal) REFERENCES public.jadwal_lapangan(id_jadwal);
 V   ALTER TABLE ONLY public.cart_pemesanan DROP CONSTRAINT cart_pemesanan_id_jadwal_fkey;
       public               postgres    false    4815    222    236            �           2606    17670 *   cart_pemesanan cart_pemesanan_id_user_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.cart_pemesanan
    ADD CONSTRAINT cart_pemesanan_id_user_fkey FOREIGN KEY (id_user) REFERENCES public."user"(id_user);
 T   ALTER TABLE ONLY public.cart_pemesanan DROP CONSTRAINT cart_pemesanan_id_user_fkey;
       public               postgres    false    236    224    4819            �           2606    17351 3   detail_pemesanan detail_pemesanan_id_pemesanan_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.detail_pemesanan
    ADD CONSTRAINT detail_pemesanan_id_pemesanan_fkey FOREIGN KEY (id_pemesanan) REFERENCES public.pemesanan(id_pemesanan);
 ]   ALTER TABLE ONLY public.detail_pemesanan DROP CONSTRAINT detail_pemesanan_id_pemesanan_fkey;
       public               postgres    false    228    226    4821            �           2606    17307 0   jadwal_lapangan jadwal_lapangan_id_lapangan_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.jadwal_lapangan
    ADD CONSTRAINT jadwal_lapangan_id_lapangan_fkey FOREIGN KEY (id_lapangan) REFERENCES public.lapangan(id_lapangan);
 Z   ALTER TABLE ONLY public.jadwal_lapangan DROP CONSTRAINT jadwal_lapangan_id_lapangan_fkey;
       public               postgres    false    4813    220    222            �           2606    17295    lapangan lapangan_id_jenis_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.lapangan
    ADD CONSTRAINT lapangan_id_jenis_fkey FOREIGN KEY (id_jenis) REFERENCES public.jenis_lapangan(id_jenis);
 I   ALTER TABLE ONLY public.lapangan DROP CONSTRAINT lapangan_id_jenis_fkey;
       public               postgres    false    218    4811    220            �           2606    17389 '   log_status log_status_id_pemesanan_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.log_status
    ADD CONSTRAINT log_status_id_pemesanan_fkey FOREIGN KEY (id_pemesanan) REFERENCES public.pemesanan(id_pemesanan);
 Q   ALTER TABLE ONLY public.log_status DROP CONSTRAINT log_status_id_pemesanan_fkey;
       public               postgres    false    234    226    4821            �           2606    17376 $   pembayaran pembayaran_id_metode_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.pembayaran
    ADD CONSTRAINT pembayaran_id_metode_fkey FOREIGN KEY (id_metode) REFERENCES public.metode_pembayaran(id_metode);
 N   ALTER TABLE ONLY public.pembayaran DROP CONSTRAINT pembayaran_id_metode_fkey;
       public               postgres    false    230    4825    232            �           2606    17371 '   pembayaran pembayaran_id_pemesanan_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.pembayaran
    ADD CONSTRAINT pembayaran_id_pemesanan_fkey FOREIGN KEY (id_pemesanan) REFERENCES public.pemesanan(id_pemesanan);
 Q   ALTER TABLE ONLY public.pembayaran DROP CONSTRAINT pembayaran_id_pemesanan_fkey;
       public               postgres    false    4821    232    226            �           2606    17339 "   pemesanan pemesanan_id_jadwal_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.pemesanan
    ADD CONSTRAINT pemesanan_id_jadwal_fkey FOREIGN KEY (id_jadwal) REFERENCES public.jadwal_lapangan(id_jadwal);
 L   ALTER TABLE ONLY public.pemesanan DROP CONSTRAINT pemesanan_id_jadwal_fkey;
       public               postgres    false    226    4815    222            �           2606    17334 $   pemesanan pemesanan_id_lapangan_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.pemesanan
    ADD CONSTRAINT pemesanan_id_lapangan_fkey FOREIGN KEY (id_lapangan) REFERENCES public.lapangan(id_lapangan);
 N   ALTER TABLE ONLY public.pemesanan DROP CONSTRAINT pemesanan_id_lapangan_fkey;
       public               postgres    false    4813    220    226            �           2606    17329     pemesanan pemesanan_id_user_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.pemesanan
    ADD CONSTRAINT pemesanan_id_user_fkey FOREIGN KEY (id_user) REFERENCES public."user"(id_user);
 J   ALTER TABLE ONLY public.pemesanan DROP CONSTRAINT pemesanan_id_user_fkey;
       public               postgres    false    224    226    4819            �   .   x�3�4�4�4202�50�54Q04�25�25ѳ0�00������� �      �   #   x�3�4�JL�,�4�063726�0������� S�p      �   H   x�3�4�4202�50�52�44�20 "NC(#$��85%3��� �L8M�ZM9̡*,ѵB4��qqq O>         )   x�3�t+-)N��2�����2�tJL���+������� �<	      �   E   x�3��I,H�KO�S0�4�2Bp��\c��5AVl�e��؈�Y��9�bc.d��\�Ȋ��b���� H*$X      �      x������ � �      �   1   x�3�tN,�����2�)J�+NK-Rprv�4426153��4������ ��	�      �   4   x�3�4�4�4202�50�54Q0��22�26г0��4���)�K,����� ��      �   3   x�3�4�4�4�t�.�L�41� =N##S]3]CN�Ҽ�b�=... ��	�      �   4   x�3�tJ��Vptr�4426153��4�H�����V�I,H�KO������ ��{      �   o   x�3�tL���Sp�L�鹉�9z������1��e�Z�ZTW���Y���(RV����^���e�RR�QjhVV@Rl1�%57�3H Tgbj�P���� �8     