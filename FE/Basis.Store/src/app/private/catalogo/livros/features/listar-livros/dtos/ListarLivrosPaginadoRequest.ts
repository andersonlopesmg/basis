import { PaginacaoDto } from '../../../../../../common/dtos/Paginacao.dto';
import { LivroFilter } from '../../../models/LivroFilter';

export interface ListarLivrosPaginadoRequest {
    Paginacao: PaginacaoDto;
    Filtro: LivroFilter;
}