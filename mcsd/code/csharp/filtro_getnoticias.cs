/*
   Implementación de Clase Filtro
 */


[Serializable]
    [DataContract]
    public class Filtro
    {
        public const int MIN_CANTIDAD_DEFAULT = 5;
        public const int MAX_CANTIDAD_DEFAULT = 100;
        private int _IdNoticia = 0, _IdEstatus = 0, _IdCategoria = 0, _IdContenido = 0, _Cantidad = MIN_CANTIDAD_DEFAULT, _IdCuenta = 0, _Dia, _Mes, _Anio;

        private List<int> _IdsCategoria = new List<int>();

        public List<int> IdsCategoria
        {
            get { return _IdsCategoria; }
            set { _IdsCategoria = value; }
        }

        public int Dia
        {
            get { return _Dia; }
            set { _Dia = value; }
        }

        public int Mes
        {
            get { return _Mes; }
            set { _Mes = value; }
        }

        public int Anio
        {
            get { return _Anio; }
            set { _Anio = value; }
        }

        public int IdNoticia
        {
            get { return _IdNoticia; }
            set { _IdNoticia = value; }
        }

        public int IdCuenta
        {
            get { return _IdCuenta; }
            set { _IdCuenta = value; }
        }

        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }
        [Obsolete("Cambie a la clase Filtro.Por.Contenidos", true)]
        /// <summary>
        /// Indica IdContenido para aplicar el filtro. 
        /// Id especifico usar: ByContenido=true,
        /// Excluir Id user: ByContenido=true y IgnoreContenido=true
        /// </summary>
        public int IdContenido
        {
            get { return _IdContenido; }
            set { _IdContenido = value; }
        }
        [Obsolete("Cambie a la clase Filtro.Por.Categorias", true)]
        /// <summary>
        /// Indica IdCategoria para aplicar el filtro, depende la propiedad ByCategoria=true;
        /// </summary>
        public int IdCategoria
        {
            get { return _IdCategoria; }
            set { _IdCategoria = value; }
        }
        [Obsolete("Cambie a la clase Filtro.Por.Estatus", true)]
        /// <summary>
        /// Indica IdEstatus para aplicar el filtro, depende la propiedad ByEstatus=true;
        /// </summary>
        public int IdEstatus
        {
            get { return _IdEstatus; }
            set { _IdEstatus = value; }
        }
        private bool _ByTexto = false,
                    _ByNoticia = false,
                    _ByFecha = false,
                    _ByCategoria = false,
                    _ByCategorias = false,
                    _ByContenido = false,
                    _ByEstatus = false,
                    _ByCuenta = false,
                    _ByPagada = false,
                    _ByCantidad = false,
                    _MantenerCache=false,
                    _BuscarEnHistorico = false,
                    _ByLocalizador=false,
                    _ByFechaInNumber = false,
                    _ByVigencia = false,
                    _ByIsVisibleInHomePage = false,
                    _IsVisibleInHomePage = true,
                    _IsPagada = false,
                    _OrderDescending = true,
                    _OrderByMasLeidas=false,
                    _IgnoreCantidad = false,
                    _IgnoreContenido = false;

        public bool OrderByMasLeidas
        {
            get { return _OrderByMasLeidas; }
            set { _OrderByMasLeidas = value; }
        }



        public bool IsVisibleInHomePage
        {
            get { return _IsVisibleInHomePage; }
            set { _IsVisibleInHomePage = value; }
        }

        public bool ByIsVisibleInHomePage
        {
            get { return _ByIsVisibleInHomePage; }
            set { _ByIsVisibleInHomePage = value; }
        }


        [Obsolete("Cambie a la clase Filtro.Por.Categorias", true)]
        public bool ByCategorias
        {
            get { return _ByCategorias; }
            set { _ByCategorias = value; }
        }
        /// <summary>
        /// Mantendrá registros en cache por 5 minutos
        /// </summary>
        public bool MantenerCache
        {
            get { return _MantenerCache; }
            set { _MantenerCache = value; }
        }
        /// <summary>
        /// En caso de ser "Si" buscará las noticias en la tabla Noticias, de lo contrario buscará en la tabla NoticiaLight
        /// </summary>
        public bool BuscarEnHistorico
        {
            get { return _BuscarEnHistorico; }
            set { _BuscarEnHistorico = value; }
        }

        /// <summary>
        /// Filtrará por noticias Vigentes, tomará la fecha actual del sistema para ejecutar el filtro.
        /// </summary>
        public bool ByVigencia
        {
            get { return _ByVigencia; }
            set { _ByVigencia = value; }
        }
        /// <summary>
        /// Filtrará por Cantidad
        /// </summary>
        public bool ByCantidad
        {
            get { return _ByCantidad; }
            set { _ByCantidad = value; }
        }
        /// <summary>
        /// Filtrará noticias por Fecha, usando las propiedades Dia, Mes y Anio
        /// </summary>
        public bool ByFechaInNumber
        {
            get { return _ByFechaInNumber; }
            set { _ByFechaInNumber = value; }
        }
        [Obsolete("Cambie a la clase Filtro.Por.Contenidos", true)]
        /// <summary>
        /// Ignorará por Contenido especificado en la propiedad IdContenido
        /// </summary>
        public bool IgnoreContenido
        {
            get { return _IgnoreContenido; }
            set { _IgnoreContenido = value; }
        }
        /// <summary>
        /// Ignorará por Cantidad, tomará cantidad MAX por defecto.
        /// </summary>
        public bool IgnoreCantidad
        {
            get { return _IgnoreCantidad; }
            set { _IgnoreCantidad = value; }
        }
        /// <summary>
        /// Aplicará Orden Descencente
        /// </summary>
        public bool OrderDescending
        {
            get { return _OrderDescending; }
            set { _OrderDescending = value; }
        }
        /// <summary>
        /// Valida si la noticia está pagada
        /// </summary>
        public bool IsPagada
        {
            get { return _IsPagada; }
            set { _IsPagada = value; }
        }
        /// <summary>
        /// Filtrará por Pagos
        /// </summary>
        public bool ByPagada
        {
            get { return _ByPagada; }
            set { _ByPagada = value; }
        }
        /// <summary>
        /// Filtrará por Texto
        /// </summary>
        public bool ByTexto
        {
            get { return _ByTexto; }
            set { _ByTexto = value; }
        }
        /// <summary>
        /// Filtrará por Localizador
        /// </summary>
        public bool ByLocalizador
        {
            get { return _ByLocalizador; }
            set { _ByLocalizador = value; }
        }
        /// <summary>
        /// Filtrará por Noticia
        /// </summary>
        public bool ByNoticia
        {
            get { return _ByNoticia; }
            set { _ByNoticia = value; }
        }
        /// <summary>
        /// Filtrará por Cuenta de Usuario
        /// </summary>
        public bool ByCuenta
        {
            get { return _ByCuenta; }
            set { _ByCuenta = value; }
        }
        [Obsolete("Cambie a la clase Filtro.Por.Estatus", true)]
        /// <summary>
        /// Filtrará por Estatus
        /// </summary>
        public bool ByEstatus
        {
            get { return _ByEstatus; }
            set { _ByEstatus = value; }
        }
        [Obsolete("Cambie a la clase Filtro.Por.Contenidos", true)]
        /// <summary>
        /// Filtrará por Contenido
        /// </summary>
        public bool ByContenido
        {
            get { return _ByContenido; }
            set { _ByContenido = value; }
        }
        [Obsolete("Cambie a la clase Filtro.Por.Categorias", true)]
        /// <summary>
        /// Filtrará por Categoria
        /// </summary>
        public bool ByCategoria
        {
            get { return _ByCategoria; }
            set { _ByCategoria = value; }
        }
        /// <summary>
        /// Filtrará por Fecha
        /// </summary>
        public bool ByFecha
        {
            get { return _ByFecha; }
            set { _ByFecha = value; }
        }
        private DateTime _FechaDesde = DateTime.Now, _FechaHasta = DateTime.Now;
        /// <summary>
        /// Indica la Fecha Hasta de vigencia en la(s) noticia(s)
        /// </summary>
        public DateTime FechaHasta
        {
            get { return _FechaHasta; }
            set { _FechaHasta = value; }
        }
        /// <summary>
        /// Indica la Fecha Desde de vigencia en la(s) noticia(s)
        /// </summary>
        public DateTime FechaDesde
        {
            get { return _FechaDesde; }
            set { _FechaDesde = value; }
        }
        private string _Texto = string.Empty;
        /// <summary>
        /// Indica la Palabra y/o Texto a ser búscado en Antetitulo, Titulo, Texto, KeyWords de la(s) noticia(s)
        /// </summary>
        public string Texto
        {
            get { return _Texto; }
            set { _Texto = value; }
        }
        private string _Localizador = string.Empty;
        /// <summary>
        /// Indica la Palabra y/o Texto a ser búscado en Antetitulo, Titulo, Texto, KeyWords de la(s) noticia(s)
        /// </summary>
        public string Localizador
        {
            get { return _Localizador; }
            set { _Localizador = value; }
        }

        private Filtro.Por.Ubicaciones _Ubicaciones = new Por.Ubicaciones(false);

        public Filtro.Por.Ubicaciones Ubicaciones
        {
            get { return _Ubicaciones; }
            set { _Ubicaciones = value; }
        }

        private Filtro.Por.Categorias _Categorias = new Por.Categorias(false);

        [Obsolete("Utilizar Filtro.Por.Ubicacion")]
        public Filtro.Por.Categorias Categorias
        {
            get { return _Categorias; }
            set { _Categorias = value; }
        }

        private Filtro.Por.Contenidos _Contenidos = new Por.Contenidos(false);

        [Obsolete("Utilizar Filtro.Por.Ubicacion")]
        public Filtro.Por.Contenidos Contenidos
        {
            get { return _Contenidos; }
            set { _Contenidos = value; }
        }

        private Filtro.Por.Estatus _Estatus = new Por.Estatus(false);

        public Filtro.Por.Estatus Estatus
        {
            get { return _Estatus; }
            set { _Estatus = value; }
        }
        public abstract class AbstractFiltro : IFiltroPor
        {
            #region IFiltroPor Members
            protected bool _Filtrar = false;
            public bool Filtrar
            {
                get { return _Filtrar; }
                set { _Filtrar = value; }
            }
            private bool _SoloUn = true;
            public bool SoloUn
            {
                get
                {
                    return _SoloUn;
                }
                set
                {
                    _SoloUn = value;
                }
            }
            private bool _Incluir = true;
            public bool Incluir
            {
                get
                {
                    return _Incluir;
                }
                set
                {
                    _Incluir = value;
                }
            }
            private int _Id = 0;
            public int Id
            {
                get
                {
                    return _Id;
                }
                set
                {
                    _Id = value; ;
                }
            }
            private List<int> _Ids = new List<int>();
            public List<int> Ids
            {
                get
                {
                    return _Ids;
                }
                set
                {
                    _Ids = value;
                }
            }

            #endregion
        }



        interface IFiltroPor
        {

            bool Filtrar { get; }
            bool SoloUn { get; set; }
            bool Incluir { get; set; }
            int Id { get; set; }
            List<int> Ids { get; set; }
        }
        interface IFiltroUbicacion
        {
            bool Filtrar { get; }
            int IdCategoria { get; set; }
            int IdContenido { get; set; }
        }

        public class Por
        {
            public class Ubicaciones : IFiltroUbicacion
            {
                public Ubicaciones()
                {

                }
                public Ubicaciones(bool filtrarUbicacion)
                {
                    _Filtrar = filtrarUbicacion;
                }

                protected bool _Filtrar = false;
                public bool Filtrar
                {

                    get { return _Filtrar; }
                    set { _Filtrar = value; }
                }
                private int _IdCategoria = 0;
                public int IdCategoria
                {
                    get
                    {
                        return _IdCategoria;
                    }
                    set
                    {
                        _IdCategoria = value;
                    }
                }

                private int _IdContenido = 0;
                public int IdContenido
                {
                    get
                    {
                        return _IdContenido;
                    }
                    set
                    {
                        _IdContenido = value;
                    }
                }

                private bool _IncluirContenido = true;

                public bool IncluirContenido
                {
                    get { return _IncluirContenido; }
                    set { _IncluirContenido = value; }
                }

            }


            public class Categorias : AbstractFiltro
            {
                public Categorias()
                {

                }
                public Categorias(bool filtrarCategoria)
                {

                    _Filtrar = filtrarCategoria;
                }

            }
            public class Contenidos : AbstractFiltro
            {
                public Contenidos()
                {

                }
                public Contenidos(bool filtrarContenido)
                {
                    _Filtrar = filtrarContenido;
                }


            }
            public class Estatus : AbstractFiltro
            {
                public Estatus()
                {

                }
                public Estatus(bool filtrarEstatus)
                {
                    _Filtrar = filtrarEstatus;
                }


            }
        }
    }

/*
  Implementación de Metodo que recibe una instancia de la clase Filtro
*/

public List<Noticia> GetNoticias(Filtro filtro)
        {
            var q = Listado<Noticia>(x => x.NoticiaImagen, x => x.Ubicacion, x => x.Responsable, x => x.Cuenta, x => x.Estatu, x => x.Route);// (from n in model.NoticiaSet.OfType<Noticia>() select n);

            if (!filtro.Ubicaciones.Filtrar)
            {
                if (filtro.Categorias.Filtrar)
                {
                    if (filtro.Categorias.SoloUn)
                        if (filtro.Categorias.Incluir)
                            q = q.Where(x => x.IdCategoria == filtro.Categorias.Id);
                        else
                            q = q.Where(x => x.IdCategoria != filtro.Categorias.Id);
                    else
                        if (filtro.Categorias.Incluir)
                            q = q.Where(x => filtro.Categorias.Ids.Contains(x.IdCategoria.Value));
                        else
                            q = q.Where(x => !filtro.Categorias.Ids.Contains(x.IdCategoria.Value));
                }

                if (filtro.Contenidos.Filtrar)
                {
                    if (filtro.Contenidos.SoloUn)
                        if (filtro.Contenidos.Incluir)
                            q = q.Where(x => x.IdContenido == filtro.Contenidos.Id);
                        else
                            q = q.Where(x => x.IdContenido != filtro.Contenidos.Id);
                    else
                        if (filtro.Contenidos.Incluir)
                            q = q.Where(x => filtro.Contenidos.Ids.Contains(x.IdContenido.Value));
                        else
                            q = q.Where(x => !filtro.Contenidos.Ids.Contains(x.IdContenido.Value));
                }
            }
            else
            {
                if (filtro.Ubicaciones.IncluirContenido)
                {
                    q = q.Where(x => x.Ubicacion.Where(y => y.IdCategoria.Value == filtro.Ubicaciones.IdCategoria
                                                      && y.IdContenido.Value == filtro.Ubicaciones.IdContenido).FirstOrDefault() != null);
                }
                else
                {
                    q = q.Where(x => x.Ubicacion.Where(y => y.IdCategoria.Value == filtro.Ubicaciones.IdCategoria).FirstOrDefault() != null);
                }
            }
            if (filtro.Estatus.Filtrar)
            {
                if (filtro.Estatus.SoloUn)
                    if (filtro.Estatus.Incluir)
                        q = q.Where(x => x.IdEstatus == filtro.Estatus.Id);
                    else
                        q = q.Where(x => x.IdEstatus != filtro.Estatus.Id);
                else
                    if (filtro.Estatus.Incluir)
                        q = q.Where(x => filtro.Estatus.Ids.Contains(x.IdEstatus.Value));
                    else
                        q = q.Where(x => !filtro.Estatus.Ids.Contains(x.IdEstatus.Value));
            }

            if (filtro.ByCuenta)
                q = q.Where(x => x.IdCuenta == filtro.IdCuenta);
            if (filtro.ByFecha)
            {
                if (filtro.ByFechaInNumber)
                    q = q.Where(x => x.FechaDesde.Value.Day == filtro.Dia && x.FechaDesde.Value.Month == filtro.Mes && x.FechaDesde.Value.Year == filtro.Anio);
                else
                    q = q.Where(x => x.FechaDesde >= filtro.FechaDesde && x.FechaDesde <= filtro.FechaHasta);
            }
            if (filtro.ByVigencia)
            {
                DateTime ahora = Global.CNF_ZonaHoraria_esVE;
                q = q.Where(x => ahora >= x.FechaDesde && x.FechaHasta >= ahora);
            }
            if (filtro.ByNoticia)
                q = q.Where(x => x.Id == filtro.IdNoticia);
            if (filtro.ByPagada)
                q = q.Where(x => x.IsPagada == filtro.IsPagada);
            if (filtro.ByTexto)
                q = q.Where(x => x.Titulo.Contains(filtro.Texto) || x.KeyWords.Contains(filtro.Texto) || x.Credito.Contains(filtro.Texto));
            if (filtro.ByLocalizador)
                q = q.Where(x => x.LoteTransferencia.Trim() == filtro.Localizador.Trim());
            //q = q.Where(x => x.Texto.Contains(filtro.Texto) || x.Titulo.Contains(filtro.Texto) || x.Antetitulo.Contains(filtro.Texto) || x.KeyWords.Contains(filtro.Texto));
            if (filtro.OrderDescending)
                q = q.OrderByDescending(x => x.FechaDesde).ThenByDescending(x => x.Id);
            else
                q = q.OrderByDescending(x => x.Id);
            if (filtro.OrderByMasLeidas)
                q = q.OrderByDescending(x => x.Contador.FirstOrDefault().Cantidad);
            if (filtro.ByCantidad)
            {
                if (filtro.IgnoreCantidad)
                    q = q.Take(Filtro.MAX_CANTIDAD_DEFAULT);
                else
                    if (filtro.Cantidad == Filtro.MIN_CANTIDAD_DEFAULT)
                        q = q.Take(Filtro.MIN_CANTIDAD_DEFAULT);
                    else
                        q = q.Take(filtro.Cantidad);
            }
            else
                q = q.Take(Filtro.MIN_CANTIDAD_DEFAULT);
            if (filtro.ByIsVisibleInHomePage)
                q = q.Where(x => x.IsVisibleInHomePage == filtro.IsVisibleInHomePage);
            string query=((ObjectQuery)q).ToTraceString();

            // string query=((ObjectQuery)q).ToTraceString();

            if (filtro.MantenerCache)
            {
                /* ----------------------------------------------------------
                 * Implementación para controlar cache en retorno de datos
                 * ---------------------------------------------------------- */
                ObjectCache cache = MemoryCache.Default;
                List<Noticia> noticias = cache["noticias"] as List<Noticia>;
                if (noticias == null)
                {

                    CacheItemPolicy policy = new CacheItemPolicy { AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(Global.CNF_NoticiasEnCacheMinutos) };
                    noticias = q.ToList();
                    cache.AddOrGetExisting("noticias", noticias, policy);
                }
                return noticias;
            }
            else {
                return q.ToList();
            }
        }
