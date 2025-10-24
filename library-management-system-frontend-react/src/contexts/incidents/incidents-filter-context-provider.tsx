import { type ReactNode, useCallback, useEffect, useMemo, useState } from 'react';

import type { IncidentType } from '@/types';

import IncidentFilterContext from '@/contexts/incidents/incidents-filter-context';
import useGetIncidentListData from '@/hooks/use-get-incident-list-data';

interface TIncidentFilterProvider {
  children: ReactNode;
}

export default function IncidentFilterProvider({ children }: TIncidentFilterProvider) {
  const [incidentsData, setIncidentsData] = useState<IncidentType[]>([]);
  const [showFilter, setShowFilter] = useState(false);
  const [isFilterApplied, setIsFilterApplied] = useState(false);
  const [filteredStations, setFilteredStations] = useState<string[]>([]);
  const [filteredRoutes, setFilteredRoutes] = useState<string[]>([]);

  const {
    isLoading: isIncidentListLoading,
    isError: isIncidentListError,
    data: incidentList,
    refetch: refetchIncidentList,
    failureCount: incidentListFailureCount,
  } = useGetIncidentListData();
  // TODO: remove this effect

  const incidents = incidentList || [];

  useEffect(() => {
    setIncidentsData(incidents);
  }, [incidentList]);

  const isFilterable = !!(filteredStations.length || filteredRoutes.length);
  const appliedFilterCount = filteredStations.length + filteredRoutes.length;

  // possible refactor. Check routes filter context
  const applyFilters = useCallback(() => {
    if (!incidentList) {
      return;
    }

    const filteredIncidents = new Set();

    if (filteredStations.length === 0 && filteredRoutes.length === 0) {
      incidentList.forEach((incident) => filteredIncidents.add(incident));
    }

    if (filteredStations.length > 0) {
      incidentList
        .filter((item) => item.stopIds?.some((stopId) => filteredStations.includes(stopId)))
        .forEach((incident) => filteredIncidents.add(incident));
    }

    if (filteredRoutes.length > 0) {
      incidentList
        .filter((item) => item.journeyIds?.some((journeyId) => filteredRoutes.includes(journeyId)))
        .forEach((incident) => filteredIncidents.add(incident));
    }

    setIncidentsData([...filteredIncidents] as IncidentType[]);
    setIsFilterApplied(isFilterable);
  }, [filteredStations, filteredRoutes, incidentList, isFilterable]);

  const clearAllFilters = useCallback(() => {
    setFilteredStations([]);
    setFilteredRoutes([]);
    setIncidentsData(incidents);
    setIsFilterApplied(false);
    setShowFilter(false);
  }, []);

  const contextValue = useMemo(
    () => ({
      incidentsData,
      setIncidentsData,
      showFilter,
      setShowFilter,
      filteredStations,
      setFilteredStations,
      filteredRoutes,
      setFilteredRoutes,
      isFilterable,
      isFilterApplied,
      appliedFilterCount,
      applyFilters,
      clearAllFilters,
      isIncidentListLoading,
      refetchIncidentList,
      isIncidentListError,
      incidentListFailureCount,
    }),
    [
      incidentsData,
      showFilter,
      appliedFilterCount,
      isFilterApplied,
      filteredStations,
      filteredRoutes,
      isFilterable,
      isIncidentListLoading,
      refetchIncidentList,
      isIncidentListError,
      incidentListFailureCount,
    ]
  );

  return <IncidentFilterContext value={contextValue}>{children}</IncidentFilterContext>;
}
