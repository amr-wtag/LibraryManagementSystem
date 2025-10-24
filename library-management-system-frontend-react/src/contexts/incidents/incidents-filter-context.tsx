import { createContext, type Dispatch, type SetStateAction } from 'react';

import type { IncidentType } from '@/types';

interface IncidentFilterContextType {
  incidentsData: IncidentType[];
  showFilter: boolean;
  setShowFilter: Dispatch<SetStateAction<boolean>>;
  filteredStations: string[];
  setFilteredStations: Dispatch<SetStateAction<string[]>>;
  filteredRoutes: string[];
  setFilteredRoutes: Dispatch<SetStateAction<string[]>>;
  isFilterable: boolean;
  isFilterApplied: boolean;
  appliedFilterCount: number;
  clearAllFilters: () => void;
  applyFilters: () => void;
  isIncidentListLoading?: boolean;
  refetchIncidentList: () => void;
  isIncidentListError?: boolean;
  incidentListFailureCount: number | 0;
}

const IncidentFilterContext = createContext<IncidentFilterContextType | null>(null);

export default IncidentFilterContext;
