Feature: Deposit feature
    Scenario: Deposit money successfully
        Given an account with balance 100
        When I deposit 50
        Then the new balance should be 150