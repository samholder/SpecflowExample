@ExportsTests @GridExportTests
Feature: GridExportTests
    Tests export to excel within grid pages of the application

@InitiativeExport
Scenario: Initiative Export - Select all Physicians 
    Given I am on the Initiatives page
    When I select the first initiative

@TargetExport
Scenario: Targets Export
    Given I am on the Targets page
    When I filter Employment Status by 'Employed by us'

@TargetExportConnections
Scenario: Targets Export - Connections
    Given I am on the Targets page
    And no filters are applied